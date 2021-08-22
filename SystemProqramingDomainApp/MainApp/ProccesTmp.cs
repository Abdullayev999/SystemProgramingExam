using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class ProccesTmp
    {
        public string ProcessName { get; set; } 
        public string MainWindowTitle { get; set; }
        public int Id { get; set; }
        public ProcessModule MainModule { get; set; } 
        public TimeSpan TotalProcessorTime { get; set; }
        public override string ToString()
        {
            return   ProcessName.PadRight(30, ' ') + MainWindowTitle + TotalProcessorTime.ToString().PadRight(30, ' ');
        }
    }
}
