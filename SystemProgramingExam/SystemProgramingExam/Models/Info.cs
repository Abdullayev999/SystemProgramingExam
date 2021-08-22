using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramingExam.Models
{
    public class Info
    {
        public DateTime StartTime { get; set; }
        public ObservableCollection<string> Statistic { get; set; }
        public ObservableCollection<string> FilesPath { get; set; }
    }
}
