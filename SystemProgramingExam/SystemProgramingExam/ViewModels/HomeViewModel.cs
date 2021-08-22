using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using SystemProgramingExam.Models;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace SystemProgramingExam.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public List<Task> Tasks { get; set; }
        public int Value { get; set; }
        public HomeViewModel()
        {
            ListForbiddenWords = new List<string>();
            Tasks = new List<Task>();
        }
        public void Check()
        {
            bool resultStart = true;
            if (IsWrite)
            {
                IsWriteVisibility = Visibility.Visible;
                IsFileVisibility = Visibility.Hidden;

                if (string.IsNullOrWhiteSpace(ForbiddenWords))  resultStart = false;
                
            }
            else
            {
                IsWriteVisibility = Visibility.Hidden;
                IsFileVisibility = Visibility.Visible;

                if (ForbiddenWordsPath.Equals(@"Path:\"))  resultStart = false;
                 
            }

            if (IsName)
            {
                IsNameVisibility = Visibility.Visible;
                IsPathVisibility = Visibility.Hidden;

                if (string.IsNullOrWhiteSpace(SearchName)) resultStart = false;
                
            }
            else
            {
                IsNameVisibility = Visibility.Hidden;
                IsPathVisibility = Visibility.Visible;

                if (SearchPath.Equals(@"Path:\"))  resultStart = false;
                 
            }

            if (WhereCopy.Equals(@"Path:\")) resultStart = false;
            

            StartButton = resultStart;
        }

        public void Loading()
        {
            Value = 0;
            IsFinish = false;
            do
            {
                Thread.Sleep(100);
                Value += 1;
                if (Value == 100)
                {
                    Value = 0;
                }

                if (IsFinish == true)
                {
                    Value = 100;
                    break;
                }
            } while (true);
        }

        private string searchPath = @"Path:\";

        public string SearchPath
        {
            get { return searchPath; }
            set
            {
                searchPath = value;
                Check();
            }

        }

        private RelayCommand forbiddenWordPathCommand = null;
        public RelayCommand ForbiddenWordPathCommand => forbiddenWordPathCommand = new RelayCommand(
        () =>
        {
            OpenFileDialog openFile = new OpenFileDialog();
            var result = openFile.ShowDialog();
            if (result.Value)
            {
                ForbiddenWordsPath = openFile.FileName;
            } 
        });

        private RelayCommand searchFolderPathCommand = null;
        public RelayCommand SearchFolderPathCommand => searchFolderPathCommand = new RelayCommand(
        () =>
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SearchPath = folderBrowserDialog.SelectedPath;
            }
            //  MessageBox.Show("Test");
        });
        private RelayCommand whereCopyCommand = null;
        public RelayCommand WhereCopyCommand => whereCopyCommand = new RelayCommand(
        () =>
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK) WhereCopy = folderBrowserDialog.SelectedPath;
 
        });


        private bool isWrite = true;

        public bool IsWrite
        {
            get { return isWrite; }
            set
            {
                isWrite = value;
                Check();
            }
        }

        private bool isName = true;

        public bool IsName
        {
            get { return isName; }
            set
            {
                isName = value;
                Check();
            }
        }
        public bool StartButton { get; set; } = false;
        private string searchName;

        public string SearchName
        {
            get { return searchName; }
            set
            {
                searchName = value;
                Check();
            }
        }

        public List<string> ListForbiddenWords { get; set; }
        private RelayCommand forbiddenClearCommand = null;

        public RelayCommand ForbiddenClearCommand => forbiddenClearCommand = new RelayCommand(
        () =>
        {
            ForbiddenWords = string.Empty;
        });

        private RelayCommand searchClearCommand = null;

        public RelayCommand SearchClearCommand => searchClearCommand = new RelayCommand(
        () =>
        {
            SearchName = string.Empty;
        });

        private string forbiddenWords;

        public string ForbiddenWords
        {
            get { return forbiddenWords; }
            set
            {
                forbiddenWords = value;
                Check();
            }
        }

        public string ForbiddenWordsPath { get; set; } = @"Path:\";
        public Visibility IsWriteVisibility { get; set; } = Visibility.Visible;
        public Visibility IsFileVisibility { get; set; } = Visibility.Collapsed;
        public Visibility IsNameVisibility { get; set; } = Visibility.Visible;
        public Visibility IsPathVisibility { get; set; } = Visibility.Collapsed;

        private RelayCommand startCommand = null;
        public bool IsFinish { get; set; } 
        public RelayCommand StartCommand => startCommand = new RelayCommand(
        async () =>
        {
            dateTime = DateTime.Now; 
            BeginStart();

            Tasks.Add(Task.Run(() => { Loading(); }));
            Tasks.Add(Task.Run(() => { ForbidenWords(); }));


            await Task.Run(() => { ReadAllFolderByDirectory(@"C:\", @"D:\"); }); 

            CheckPathForCreat();

            await Task.Run(() => { SearchAndChange(); });
            await Task.Run(() => { Information(); });


            IsFinish = true;
        });

        public ObservableCollection<Info> ListsInfo { get; set; } = new ObservableCollection<Info>();
        public Task Starting { get; set; }
        public DateTime dateTime { get; set; }
        public void BeginStart()
        {
            Tasks.Clear();
            KeyValues.Clear();
            FolderFound.Clear();
            FilesFound.Clear();
            TextBuilder.Clear();
        }
        public void CheckPathForCreat()
        {
            if (!WhereCopy.EndsWith(@"\Results"))  WhereCopy += @"\Results";
              
            if (!Directory.Exists(WhereCopy))  Directory.CreateDirectory(WhereCopy); 
        }
        StringBuilder TextBuilder { get; set; } = new StringBuilder(300);
        public string InformationPath { get; set; } = @"\Information.txt";
        public void Information()
        {
            TextBuilder.Append("---------------------------------\nStart date : " + dateTime + "\n---------------------------------\n\n");
            if (!File.Exists(WhereCopy + InformationPath))
                File.Create(WhereCopy + InformationPath).Close();

            TextBuilder.Append("Forbiden Words  :  ");

            foreach (var word in ListForbiddenWords)  TextBuilder.Append(word + " ");
             

            TextBuilder.Append("\n\n");

            TextBuilder.Append("Files Found : \n");
            int result = 0;
            foreach (var item in FilesFound)  TextBuilder.Append(++result + ") " + item + "\n");
             
            TextBuilder.Append("\n\n");

            int count = 1;
 
            foreach (var text in FilesFound)
            {
                var tmp = File.ReadAllText(text);
                var words = tmp.Split(' ', '!', '.', '?');

                foreach (var item in ListForbiddenWords)
                {
                    int quantity = words.Where(str => str.Equals(item)).Count();
                    KeyValues[item] += quantity;

                }
            }
            TextBuilder.Append("Statistic \n\n");

          var statics =   KeyValues.OrderByDescending(str => str.Value);

            var info = new Info();
            info.StartTime = dateTime;
            info.FilesPath = new ObservableCollection<string>(FilesFound);
            info.Statistic = new ObservableCollection<string>();

            foreach (var item in statics)
            {
                var newText = count++ + ") " + item.Value.ToString().PadRight(2, ' ') + " times  : \"" + item.Key + "\"\n";
                TextBuilder.Append(newText);
                info.Statistic.Add(newText);
            }

            TextBuilder.Append("\n\n");

            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            { 
                    ListsInfo.Add(info);
            });
         
            File.AppendAllText(WhereCopy + InformationPath, TextBuilder.ToString());



        }
        public Dictionary<string, int> KeyValues { get; set; } = new Dictionary<string, int>();
        public void ReadAllFolderByDirectory(params string[] dirs)
        {
            foreach (var sDir in dirs)
            {
                Task.Run(() => { DirSearchAsync(sDir); });
            }
        }

        private void SearchAndChange()
        {
            if (IsName) SearchingWordsByFolderNameAsync(); 
            else  SearchingWords();
             
        }
        private void ForbidenWords()
        {
            ListForbiddenWords.Clear();
            string[] tmp;

            if (isWrite)
                tmp = ForbiddenWords.Split(' ', '!', '.', '?');
            else
                tmp = File.ReadAllText(ForbiddenWordsPath).Split(' ', '!', '.', '?');

            foreach (var word in tmp)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    ListForbiddenWords.Add(word.Trim());
                    KeyValues.Add(word.Trim(), 0);
                }
            }
        }
        public object locker { get; set; } = new object();
        private string whereCopy = @"Path:\";

        public string WhereCopy
        {
            get { return whereCopy; }
            set
            {
                whereCopy = value;
                Check();
            }
        }
        public List<string> FolderFound { get; set; } = new List<string>();

        public List<string> FilesFound { get; set; } = new List<string>();
        private async void DirSearchAsync(string sDir)
        {
            try
            {
                var directories = Directory.GetDirectories(sDir);
                foreach (var directory in directories)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                    if (directoryInfo.Name.Equals(searchName))
                    {
                        FolderFound.Add(directoryInfo.FullName);
                    }
                     
                  await Task.Run(() => { DirSearchAsync(directory); });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SearchingWordsByFolderNameAsync()
        {
            Thread.Sleep(2500);
            foreach (var directoryPath in FolderFound)
            {
                DirectoryInfo directory = new DirectoryInfo(directoryPath);


                var directories = directory.GetFiles().Where(i => i.Name.EndsWith(".txt"));
                foreach (var item in directories)
                {
                    var text = File.ReadAllText(item.FullName);
                    int quantity = 0;
                    foreach (var word in text.Split(' ', '!', '.', '?'))
                    {
                        quantity += ListForbiddenWords.Where(str => str.Equals(word)).Count();

                    }
                    if (quantity > 0)
                    {

                        try
                        {
                            int num = new Random().Next(1,1000);
                            FilesFound.Add(item.FullName);
                            var tmpText = File.ReadAllText(item.FullName);
                            File.Copy(item.FullName, $@"{WhereCopy}\Original_{num}_{item.Name}");
                            foreach (var word in ListForbiddenWords)
                            {
                                string pattern = $@"\b{word}\b";
                                tmpText = Regex.Replace(tmpText, pattern, "*******");   
                            }
                            File.WriteAllText($@"{WhereCopy}\New_{num}_{item.Name}", tmpText);
                        }
                        catch (Exception) { }
                    }
                }
            }
        }
        public void SearchingWords()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(searchPath); 
            foreach (FileInfo item in directoryInfo.GetFiles())
            {

                if (item.Extension.Equals(".txt"))
                {
                    var text = File.ReadAllText(item.FullName);
                    int quantity = 0;
                    foreach (var word in text.Split(' ', '!', '.', '?'))
                    {
                        quantity += ListForbiddenWords.Where(str => str.Equals(word)).Count();

                    }
                    if (quantity > 0)
                    {
                        try
                        {
                            int num = new Random().Next(1, 1000);
                            FilesFound.Add(item.FullName);
                            var tmpText = File.ReadAllText(item.FullName);
                            File.Copy(item.FullName, $@"{WhereCopy}\Original_{num}_{item.Name}");
                            foreach (var word in ListForbiddenWords)
                            {
                                string pattern = $@"\b{word}\b";
                                tmpText = Regex.Replace(tmpText, pattern, "*******");
                            }
                            File.WriteAllText($@"{WhereCopy}\New_{num}_{item.Name}", tmpText);
                        }
                        catch (Exception) { }
                    }
                } 
            }
        }

    }
}
