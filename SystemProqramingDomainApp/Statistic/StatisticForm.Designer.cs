
namespace Statistic
{
    partial class StatisticForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTracking = new System.Windows.Forms.RichTextBox();
            this.textBoxTrackingWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxStatistic = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTracking);
            this.panel1.Controls.Add(this.textBoxTrackingWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(405, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 210);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTracking
            // 
            this.textBoxTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTracking.Location = new System.Drawing.Point(0, 0);
            this.textBoxTracking.Name = "textBoxTracking";
            this.textBoxTracking.ReadOnly = true;
            this.textBoxTracking.Size = new System.Drawing.Size(219, 172);
            this.textBoxTracking.TabIndex = 4;
            this.textBoxTracking.Text = "";
            // 
            // textBoxTrackingWords
            // 
            this.textBoxTrackingWords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTrackingWords.Location = new System.Drawing.Point(0, 172);
            this.textBoxTrackingWords.Multiline = true;
            this.textBoxTrackingWords.Name = "textBoxTrackingWords";
            this.textBoxTrackingWords.ReadOnly = true;
            this.textBoxTrackingWords.Size = new System.Drawing.Size(219, 38);
            this.textBoxTrackingWords.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(263, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forbidden words";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 47);
            this.panel2.TabIndex = 2;
            // 
            // richTextBoxStatistic
            // 
            this.richTextBoxStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatistic.Location = new System.Drawing.Point(0, 47);
            this.richTextBoxStatistic.Name = "richTextBoxStatistic";
            this.richTextBoxStatistic.ReadOnly = true;
            this.richTextBoxStatistic.Size = new System.Drawing.Size(405, 163);
            this.richTextBoxStatistic.TabIndex = 5;
            this.richTextBoxStatistic.Text = "";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 210);
            this.Controls.Add(this.richTextBoxStatistic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatisticForm";
            this.Text = "Statistic";
            this.LocationChanged += new System.EventHandler(this.StatisticForm_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTrackingWords;
        private System.Windows.Forms.RichTextBox textBoxTracking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxStatistic;
    }
}

