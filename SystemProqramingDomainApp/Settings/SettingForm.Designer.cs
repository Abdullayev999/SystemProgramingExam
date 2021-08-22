
namespace Settings
{
    partial class SettingForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxForbidenWordArr = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxForbiddenWord = new System.Windows.Forms.TextBox();
            this.buttonAddForbiddenWord = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxForbiddenAppList = new System.Windows.Forms.ComboBox();
            this.buttonAddForbiddenApp = new System.Windows.Forms.Button();
            this.textBoxForbiddenApp = new System.Windows.Forms.TextBox();
            this.buttonClearApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(381, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 158);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.comboBoxForbidenWordArr);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 123);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 45);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Forbidden word";
            // 
            // comboBoxForbidenWordArr
            // 
            this.comboBoxForbidenWordArr.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxForbidenWordArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForbidenWordArr.FormattingEnabled = true;
            this.comboBoxForbidenWordArr.Location = new System.Drawing.Point(0, 45);
            this.comboBoxForbidenWordArr.Name = "comboBoxForbidenWordArr";
            this.comboBoxForbidenWordArr.Size = new System.Drawing.Size(243, 33);
            this.comboBoxForbidenWordArr.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 45);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forbidden words";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxForbiddenWord);
            this.panel2.Controls.Add(this.buttonAddForbiddenWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 35);
            this.panel2.TabIndex = 0;
            // 
            // textBoxForbiddenWord
            // 
            this.textBoxForbiddenWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxForbiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForbiddenWord.Location = new System.Drawing.Point(0, 0);
            this.textBoxForbiddenWord.Multiline = true;
            this.textBoxForbiddenWord.Name = "textBoxForbiddenWord";
            this.textBoxForbiddenWord.Size = new System.Drawing.Size(195, 35);
            this.textBoxForbiddenWord.TabIndex = 1;
            // 
            // buttonAddForbiddenWord
            // 
            this.buttonAddForbiddenWord.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddForbiddenWord.Location = new System.Drawing.Point(195, 0);
            this.buttonAddForbiddenWord.Name = "buttonAddForbiddenWord";
            this.buttonAddForbiddenWord.Size = new System.Drawing.Size(48, 35);
            this.buttonAddForbiddenWord.TabIndex = 0;
            this.buttonAddForbiddenWord.Text = "➕";
            this.buttonAddForbiddenWord.UseVisualStyleBackColor = true;
            this.buttonAddForbiddenWord.Click += new System.EventHandler(this.buttonAddForbiddenWord_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 45);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(274, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forbidden App";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.comboBoxForbiddenAppList);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 78);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 33);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(110, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(255, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter app name";
            // 
            // comboBoxForbiddenAppList
            // 
            this.comboBoxForbiddenAppList.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxForbiddenAppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForbiddenAppList.FormattingEnabled = true;
            this.comboBoxForbiddenAppList.Location = new System.Drawing.Point(0, 0);
            this.comboBoxForbiddenAppList.Name = "comboBoxForbiddenAppList";
            this.comboBoxForbiddenAppList.Size = new System.Drawing.Size(381, 33);
            this.comboBoxForbiddenAppList.TabIndex = 2;
            // 
            // buttonAddForbiddenApp
            // 
            this.buttonAddForbiddenApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddForbiddenApp.Location = new System.Drawing.Point(333, 123);
            this.buttonAddForbiddenApp.Name = "buttonAddForbiddenApp";
            this.buttonAddForbiddenApp.Size = new System.Drawing.Size(48, 35);
            this.buttonAddForbiddenApp.TabIndex = 3;
            this.buttonAddForbiddenApp.Text = "➕";
            this.buttonAddForbiddenApp.UseVisualStyleBackColor = true;
            this.buttonAddForbiddenApp.Click += new System.EventHandler(this.buttonAddForbiddenApp_Click);
            // 
            // textBoxForbiddenApp
            // 
            this.textBoxForbiddenApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxForbiddenApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForbiddenApp.Location = new System.Drawing.Point(0, 123);
            this.textBoxForbiddenApp.Multiline = true;
            this.textBoxForbiddenApp.Name = "textBoxForbiddenApp";
            this.textBoxForbiddenApp.Size = new System.Drawing.Size(333, 35);
            this.textBoxForbiddenApp.TabIndex = 4;
            // 
            // buttonClearApp
            // 
            this.buttonClearApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClearApp.Location = new System.Drawing.Point(285, 123);
            this.buttonClearApp.Name = "buttonClearApp";
            this.buttonClearApp.Size = new System.Drawing.Size(48, 35);
            this.buttonClearApp.TabIndex = 5;
            this.buttonClearApp.Text = "🗑";
            this.buttonClearApp.UseVisualStyleBackColor = true;
            this.buttonClearApp.Click += new System.EventHandler(this.buttonClearApp_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 158);
            this.Controls.Add(this.buttonClearApp);
            this.Controls.Add(this.textBoxForbiddenApp);
            this.Controls.Add(this.buttonAddForbiddenApp);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.LocationChanged += new System.EventHandler(this.SettingForm_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxForbidenWordArr;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxForbiddenWord;
        private System.Windows.Forms.Button buttonAddForbiddenWord;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForbiddenAppList;
        private System.Windows.Forms.Button buttonAddForbiddenApp;
        private System.Windows.Forms.TextBox textBoxForbiddenApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearApp;
    }
}

