using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Statistic
{
    public partial class StatisticForm : Form
    {
        private const int WM_KEYBOARD_LL = 13; 
        private const int WM_KEYDOWN = 0x0100;  
        private static HookProc proc = HookCallback;
        private static IntPtr hook = IntPtr.Zero;
        public static string Tracking { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] 
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private  static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        Module MainModule { get; set; }
        object main;
        public string Path { get; set; } = "test.txt";
        public string Path2 { get; set; } = "test2.txt";

        public Dictionary<string, int> KeyValues { get; set; } = new Dictionary<string, int>(); 
        public StatisticForm(Module mainModule, object main)
        {
            InitializeComponent(); 
            File.Create("test.txt").Close();
            File.Create("test2.txt").Close();
            File.Create(Result).Close();

            this.MainModule = mainModule;
            this.main = main;
             
            Task.Run(() =>
            { 
                   hook = SetHook(proc);
                   Application.Run(this); 
            }); 
            Task.Run(() =>
            { 
                do
                {
                    Thread.Sleep(500); 
                    if (!string.IsNullOrWhiteSpace(Tracking))
                    { 
                        Dispatcher.CurrentDispatcher.Invoke(() =>
                        {
                            textBoxTracking.Text = string.Empty;
                            StringBuilder tmp = new StringBuilder(100);
                            foreach (var item in File.ReadAllLines(Path))
                            {
                                tmp.Insert(0,( item + "\n"));
                            }
                            textBoxTracking.Text = tmp.ToString(); 
                            textBoxTrackingWords.Text = File.ReadAllText(Path2);
                        });
                    }
                } while (true);
            }); 
        }
         
        public StringBuilder TextBuilder { get; set; } = new StringBuilder(300);
        public string Result { get; set; } = "result.txt";
        public Thread thread { get; set; }

        
        public void ForbiddenAppClear()
        {
            MainModule.GetType("MainApp.MainForm")
                     .GetMethod("ForbiddenAppClear")
                     .Invoke(main, new object[] { });
        }
        public void ForbiddenApp(List<string> listForbiddenWords)
        {
            MainModule.GetType("MainApp.MainForm")
                       .GetMethod("ForbiddenApp")
                       .Invoke(main, new object[]
                       {
                              listForbiddenWords
                       });
        }
         
        public void Information(List<string> listForbiddenWords)
        { 
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }

            KeyValues.Clear();
            File.Create(Result).Close();
            TextBuilder.Clear(); 

            thread = new Thread(() =>
            { 
                do
                {
                    KeyValues.Clear();
                    File.Create(Result).Close();
                    TextBuilder.Clear();

                    Thread.Sleep(500);

                    TextBuilder.Append("Forbiden Words  :  ");

                    foreach (var word in listForbiddenWords)
                    {
                        KeyValues.Add(word,0);
                        TextBuilder.Append(word + " ");
                    } 
                    TextBuilder.Append("\n\n");
                    int count = 1; 

                    string tmp = File.ReadAllText(Path2).ToLower();
                     
                    foreach (string item in listForbiddenWords)
                    {
                         string newString = tmp.Replace(item.ToLower(), " "); 
                        int quantity =  newString.Split(' ').Length; 
                        KeyValues[item] = quantity - 1; 
                    }
                    TextBuilder.Append("Statistic \n\n");

                    var statics = KeyValues.OrderByDescending(str => str.Value); 
                    foreach (var item in statics)
                    { 
                        var newText = count++ + ") " + item.Value.ToString().PadRight(2, ' ') + " times  : \"" + item.Key + "\"\n";
                        TextBuilder.Append(newText);
                    } 
                    TextBuilder.Append("\n\n");
                    File.WriteAllText(Result, TextBuilder.ToString());

                    Dispatcher.CurrentDispatcher.Invoke(() =>
                    {
                        richTextBoxStatistic.Text = TextBuilder.ToString(); ;
                    }); 
                } while (true);
            });

            thread.Start(); 
        } 

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            UnhookWindowsHookEx(hook);

        }
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private  IntPtr SetHook(HookProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WM_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (wParam == (IntPtr)WM_KEYDOWN))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Tracking = "\nPress " + DateTime.Now.ToShortTimeString() +" : "+ ((Keys)vkCode).ToString();

                File.AppendAllText("test.txt", Tracking);
                File.AppendAllText("test2.txt", ((Keys)vkCode).ToString());

                //  Console.WriteLine($"{(Keys)vkCode} blocked! Hahahahaha!"); 
            }
            return CallNextHookEx(hook, nCode, wParam, lParam);

        }
        private void StatisticForm_LocationChanged(object sender, EventArgs e)
        {
            MainModule.GetType("MainApp.MainForm")
                    .GetMethod("MoveWindow")
                    .Invoke(main, new object[]
                    {
                            new Point(this.Location.X, this.Location.Y + this.Height), this.Width
                    }); 
        }

        public void MoveWindow(Point newLocation, int width)
        {
            this.Location = newLocation;
            this.Width = width;
        }
          
    }
}
