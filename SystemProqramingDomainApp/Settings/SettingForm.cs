using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Settings
{
    public partial class SettingForm : Form
    { 
        Module StatisticModule { get; set; }
        object statistic;
        public SettingForm(Module statisticModule, object statistic)
        {
            InitializeComponent();
            this.StatisticModule = statisticModule;
            this.statistic = statistic;

        } 

        private void SettingForm_LocationChanged(object sender, EventArgs e)
        {
            StatisticModule.GetType("Statistic.StatisticForm")
                   .GetMethod("MoveWindow")
                   .Invoke(statistic, new object[]
                   {
                            new Point(this.Location.X, this.Location.Y + this.Height), this.Width
                   }); 
        }

        private void buttonAddForbiddenWord_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrWhiteSpace(textBoxForbiddenWord.Text))
            {
                if (!comboBoxForbidenWordArr.Items.Contains(textBoxForbiddenWord.Text))
                {
                    comboBoxForbidenWordArr.Items.Add(textBoxForbiddenWord.Text);
                    textBoxForbiddenWord.Text = string.Empty;


                    List<string> ls = new List<string>();

                    foreach (string item in comboBoxForbidenWordArr.Items)
                    {
                        ls.Add(item);
                    }

                    StatisticModule.GetType("Statistic.StatisticForm")
                         .GetMethod("Information")
                         .Invoke(statistic, new object[]
                         {
                              ls
                         });
                }
                else
                {
                    MessageBox.Show("You added this word","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
             
            }
        }  
         
         

        private void buttonAddForbiddenApp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxForbiddenApp.Text))
            {
                if (!comboBoxForbiddenAppList.Items.Contains(textBoxForbiddenApp.Text))
                {
                    comboBoxForbiddenAppList.Items.Add(textBoxForbiddenApp.Text);
                    textBoxForbiddenApp.Text = string.Empty;


                    List<string> ls = new List<string>();

                    foreach (string item in comboBoxForbiddenAppList.Items)
                    {
                        ls.Add(item);
                    }

                    StatisticModule.GetType("Statistic.StatisticForm")
                         .GetMethod("ForbiddenApp")
                         .Invoke(statistic, new object[]
                         {
                              ls
                         });
                }
                else
                {
                    MessageBox.Show("You added this app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonClearApp_Click(object sender, EventArgs e)
        {
            comboBoxForbiddenAppList.Items.Clear();

            StatisticModule.GetType("Statistic.StatisticForm")
                         .GetMethod("ForbiddenAppClear")
                         .Invoke(statistic, new object[] { });
        }
         
    }
}
