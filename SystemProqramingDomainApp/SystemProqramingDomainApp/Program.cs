using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProqramingDomainApp
{
    static class Program
    {
        static AppDomain mainApp;  
        static Assembly mainAsm;  
        static Form mainAppForm;

        static AppDomain statisticApp;
        static Assembly statisticAsm;
        static Form statisticForm;

        static AppDomain settingApp;
        static Assembly settingAsm;
        static Form settingForm; 


        [STAThread]
        [LoaderOptimization(LoaderOptimization.MultiDomain)]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            mainApp = AppDomain.CreateDomain("MainApp");
            mainAsm = mainApp.Load(AssemblyName.GetAssemblyName("MainApp.exe"));
            mainAppForm = Activator.CreateInstance(mainAsm.GetType("MainApp.MainForm")) as Form;
             

            statisticApp = AppDomain.CreateDomain("Statistic");
            statisticAsm = statisticApp.Load(AssemblyName.GetAssemblyName("Statistic.exe"));
            statisticForm = Activator.CreateInstance(statisticAsm.GetType("Statistic.StatisticForm"), new object[]
            {
                mainAsm.GetModule("MainApp.exe"),
                mainAppForm
            }) as Form;


            settingApp = AppDomain.CreateDomain("Settings");
            settingAsm = settingApp.Load(AssemblyName.GetAssemblyName("Settings.exe"));
            settingForm = Activator.CreateInstance(settingAsm.GetType("Settings.SettingForm"), new object[]
            {
                statisticAsm.GetModule("Statistic.exe"),
                statisticForm
            }) as Form;
             
            var task1 = Task.Run(() => { MainAppStart(); });
            Thread.Sleep(300); 
            var task2 = Task.Run(() => { StatisticAppStart(); });
            Thread.Sleep(300); 
            var task3 = Task.Run(() => { SettingAppStart(); });

            mainApp.DomainUnload += TextDrawer_DomainUnload;

            Task.WaitAll(task1, task2, task3);
        }

        private static void TextDrawer_DomainUnload(object sender, EventArgs e)
        {
            MessageBox.Show($"Domain with name {(sender as AppDomain).FriendlyName} has been successfully unloaded...");
        }

        static void MainAppStart()  
        {
            mainAppForm.ShowDialog();
            AppDomain.Unload(mainApp);
            Application.Exit();
        }

        static void SettingAppStart()
        {
            settingForm.ShowDialog();
            AppDomain.Unload(settingApp); 
        }
        static void StatisticAppStart()
        { 
            statisticForm.ShowDialog();
            AppDomain.Unload(statisticApp); 
        }

    }
}
