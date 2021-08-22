using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SystemProgramingExam.ViewModels;

namespace SystemProgramingExam
{ 
    public partial class App : Application
    {
        public static Container Services { get; set; }
        public static bool IsWork;
        public static Mutex Mutex { get; set; } = new Mutex(true,"MyAppTest",out IsWork);
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); 
            RegisterServices();

            if (IsWork)
            {
                Start<HomeViewModel>();
            }
            else
            {
                MessageBox.Show("Application is already running!");
                Environment.Exit(0);
            } 
        }

        private void Start<T>() where T : ViewModelBase
        {
            var windowViewModel = Services.GetInstance<MainViewModel>();
            windowViewModel.CurrentViewModel = Services.GetInstance<T>();

            var mainWindow = new MainWindow { DataContext = windowViewModel };
            mainWindow.ShowDialog();
        }
        public void RegisterServices()
        {
            Services = new Container(); 
            Services.RegisterSingleton<IMessenger, Messenger>();
            Services.RegisterSingleton<MainViewModel>();
            Services.RegisterSingleton<HomeViewModel>(); 

            Services.Verify();
        }
    }
}
