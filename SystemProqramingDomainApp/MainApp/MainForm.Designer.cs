
namespace MainApp
{
    partial class MainForm
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
            this.labelRefresh = new System.Windows.Forms.Label();
            this.buttonKill = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRefresh);
            this.panel1.Controls.Add(this.buttonKill);
            this.panel1.Controls.Add(this.buttonStatistic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 54);
            this.panel1.TabIndex = 0;
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Location = new System.Drawing.Point(13, 13);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(58, 17);
            this.labelRefresh.TabIndex = 3;
            this.labelRefresh.Text = "Refres :";
            // 
            // buttonKill
            // 
            this.buttonKill.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKill.Location = new System.Drawing.Point(474, 0);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(75, 54);
            this.buttonKill.TabIndex = 2;
            this.buttonKill.Text = "Kill Procces";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStatistic.Location = new System.Drawing.Point(549, 0);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(75, 54);
            this.buttonStatistic.TabIndex = 0;
            this.buttonStatistic.Text = "Statistic 📖";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 232);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 286);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.Label labelRefresh;
    }
}

