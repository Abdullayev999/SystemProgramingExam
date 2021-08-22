using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public partial class MainForm : Form
    {
        public int Sec { get; set; } = 10000;
        System.Timers.Timer timer;
        public string Path { get; set; } = "procces.txt";
        public MainForm()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(Sec);
            timer.Elapsed += Timer_Elapsed1;
             
        }
        Thread thread;
        private void Timer_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }
            int tmp = Sec - 1;

            thread = new Thread(TasksFill);
            thread.Start();

            Task.Run(() =>
            {
                do
                {
                    labelRefresh.Text = "Refres in " + tmp / 1000 + " sec";
                    Thread.Sleep(1000);
                    tmp -= 1000;
                } while (tmp > 0);
            });

        }

        public void MoveWindow(Point newLocation, int width)
        {
            this.Location = newLocation;
            this.Width = width;
        }
        public List<string> ForbiddenApps { get; set; } = new List<string>();
        public void ForbiddenApp(List<string> listForbiddenApp)
        {
            ForbiddenApps = listForbiddenApp;
        } 
        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            TasksFill();
            buttonStatistic.Enabled = false;
            timer.Start(); 
        }

        private List<ProccesTmp> Tasks { get; set; } = new List<ProccesTmp>();

        private void TasksFill()
        {

            try
            {
                var items = Process.GetProcesses();
                Tasks = new List<ProccesTmp>();
                foreach (var item in items)
                {
                    try
                    {
                        ProccesTmp process = new ProccesTmp();
                        process.Id = item.Id;
                        process.MainWindowTitle = item.MainWindowTitle;
                        process.ProcessName = item.ProcessName;
                        process.TotalProcessorTime = item.TotalProcessorTime;
                        Tasks.Add(process);
                    }
                    catch (Exception)
                    {

                    }
                }

                listBox1.DataSource = Tasks;

            }
            catch (Exception)
            {

            }

            try
            {
                foreach (string proc in ForbiddenApps)
                {
                    Process.GetProcessesByName(proc).FirstOrDefault().Kill();
                    MessageBox.Show("Application << " + proc + " >> in Forbidden app!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        public void ForbiddenAppClear()
        {
            ForbiddenApps.Clear();
        }


        private void buttonKill_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
            {
                var obj = listBox1.SelectedItem as ProccesTmp;
                Process.GetProcessById(obj.Id).Kill();
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
