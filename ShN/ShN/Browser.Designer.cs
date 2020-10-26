namespace ShN
{
    partial class Browser
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDC_COMBO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDC_STOP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.IDC_EXIT = new System.Windows.Forms.Button();
            this.IDC_EXPLORER = new System.Windows.Forms.WebBrowser();
            this.IDC_PROGRESS = new System.Windows.Forms.ProgressBar();
            this.IDC_INP = new System.Windows.Forms.Button();
            this.IDC_BACK = new System.Windows.Forms.Button();
            this.IDC_FORWARD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDC_COMBO
            // 
            this.IDC_COMBO.FormattingEnabled = true;
            this.IDC_COMBO.Items.AddRange(new object[] {
            "http://localhost/MF/beg.html",
            "http://localhost/MF/ParamComp.html",
            "http://localhost/MF/Int3d.htm",
            "http://yandex.ru",
            "http://mail.ru",
            ""});
            this.IDC_COMBO.Location = new System.Drawing.Point(107, 33);
            this.IDC_COMBO.Name = "IDC_COMBO";
            this.IDC_COMBO.Size = new System.Drawing.Size(239, 24);
            this.IDC_COMBO.TabIndex = 0;
            this.IDC_COMBO.Text = "http://localhost/MF/beg.html";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес";
            // 
            // IDC_STOP
            // 
            this.IDC_STOP.Location = new System.Drawing.Point(819, 39);
            this.IDC_STOP.Name = "IDC_STOP";
            this.IDC_STOP.Size = new System.Drawing.Size(93, 23);
            this.IDC_STOP.TabIndex = 5;
            this.IDC_STOP.Text = "Стоп";
            this.IDC_STOP.UseVisualStyleBackColor = true;
            this.IDC_STOP.Click += new System.EventHandler(this.IDC_STOP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 438);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(186, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // IDC_EXIT
            // 
            this.IDC_EXIT.Location = new System.Drawing.Point(620, 564);
            this.IDC_EXIT.Name = "IDC_EXIT";
            this.IDC_EXIT.Size = new System.Drawing.Size(102, 23);
            this.IDC_EXIT.TabIndex = 7;
            this.IDC_EXIT.Text = "Закрыть";
            this.IDC_EXIT.UseVisualStyleBackColor = true;
            this.IDC_EXIT.Click += new System.EventHandler(this.IDC_EXIT_Click);
            // 
            // IDC_EXPLORER
            // 
            this.IDC_EXPLORER.Location = new System.Drawing.Point(39, 78);
            this.IDC_EXPLORER.MinimumSize = new System.Drawing.Size(20, 20);
            this.IDC_EXPLORER.Name = "IDC_EXPLORER";
            this.IDC_EXPLORER.Size = new System.Drawing.Size(873, 469);
            this.IDC_EXPLORER.TabIndex = 9;
            this.IDC_EXPLORER.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.IDC_EXPLORER_Navigated);
            this.IDC_EXPLORER.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.IDC_EXPLORER_Navigating);
            this.IDC_EXPLORER.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.IDC_EXPLORER_ProgressChanged);
            // 
            // IDC_PROGRESS
            // 
            this.IDC_PROGRESS.Location = new System.Drawing.Point(271, 564);
            this.IDC_PROGRESS.Name = "IDC_PROGRESS";
            this.IDC_PROGRESS.Size = new System.Drawing.Size(203, 23);
            this.IDC_PROGRESS.TabIndex = 10;
            // 
            // IDC_INP
            // 
            this.IDC_INP.Location = new System.Drawing.Point(389, 38);
            this.IDC_INP.Name = "IDC_INP";
            this.IDC_INP.Size = new System.Drawing.Size(100, 23);
            this.IDC_INP.TabIndex = 11;
            this.IDC_INP.Text = "Ввод";
            this.IDC_INP.UseVisualStyleBackColor = true;
            this.IDC_INP.Click += new System.EventHandler(this.IDC_INP_Click);
            // 
            // IDC_BACK
            // 
            this.IDC_BACK.Location = new System.Drawing.Point(546, 39);
            this.IDC_BACK.Name = "IDC_BACK";
            this.IDC_BACK.Size = new System.Drawing.Size(75, 23);
            this.IDC_BACK.TabIndex = 12;
            this.IDC_BACK.Text = "Назад";
            this.IDC_BACK.UseVisualStyleBackColor = true;
            this.IDC_BACK.Click += new System.EventHandler(this.IDC_BACK_Click);
            // 
            // IDC_FORWARD
            // 
            this.IDC_FORWARD.Location = new System.Drawing.Point(688, 39);
            this.IDC_FORWARD.Name = "IDC_FORWARD";
            this.IDC_FORWARD.Size = new System.Drawing.Size(75, 23);
            this.IDC_FORWARD.TabIndex = 13;
            this.IDC_FORWARD.Text = "Вперед";
            this.IDC_FORWARD.UseVisualStyleBackColor = true;
            this.IDC_FORWARD.Click += new System.EventHandler(this.IDC_FORWARD_Click);
            // 
            // INT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 599);
            this.Controls.Add(this.IDC_FORWARD);
            this.Controls.Add(this.IDC_BACK);
            this.Controls.Add(this.IDC_INP);
            this.Controls.Add(this.IDC_PROGRESS);
            this.Controls.Add(this.IDC_EXPLORER);
            this.Controls.Add(this.IDC_EXIT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.IDC_STOP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDC_COMBO);
            this.Name = "INT";
            this.Text = "Интернет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDC_COMBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IDC_STOP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button IDC_EXIT;
        private System.Windows.Forms.WebBrowser IDC_EXPLORER;
        private System.Windows.Forms.ProgressBar IDC_PROGRESS;
        private System.Windows.Forms.Button IDC_INP;
        private System.Windows.Forms.Button IDC_BACK;
        private System.Windows.Forms.Button IDC_FORWARD;
    }
}