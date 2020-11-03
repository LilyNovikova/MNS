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
            this.expectionLbl = new System.Windows.Forms.Label();
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
            this.IDC_COMBO.Location = new System.Drawing.Point(80, 27);
            this.IDC_COMBO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_COMBO.Name = "IDC_COMBO";
            this.IDC_COMBO.Size = new System.Drawing.Size(180, 21);
            this.IDC_COMBO.TabIndex = 0;
            this.IDC_COMBO.Text = "http://localhost/MF/beg.html";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес";
            // 
            // IDC_STOP
            // 
            this.IDC_STOP.Location = new System.Drawing.Point(614, 32);
            this.IDC_STOP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_STOP.Name = "IDC_STOP";
            this.IDC_STOP.Size = new System.Drawing.Size(70, 19);
            this.IDC_STOP.TabIndex = 5;
            this.IDC_STOP.Text = "Стоп";
            this.IDC_STOP.UseVisualStyleBackColor = true;
            this.IDC_STOP.Click += new System.EventHandler(this.IDC_STOP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 356);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 19);
            this.progressBar1.TabIndex = 6;
            // 
            // IDC_EXIT
            // 
            this.IDC_EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_EXIT.Location = new System.Drawing.Point(465, 458);
            this.IDC_EXIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_EXIT.Name = "IDC_EXIT";
            this.IDC_EXIT.Size = new System.Drawing.Size(76, 19);
            this.IDC_EXIT.TabIndex = 7;
            this.IDC_EXIT.Text = "Закрыть";
            this.IDC_EXIT.UseVisualStyleBackColor = true;
            this.IDC_EXIT.Click += new System.EventHandler(this.IDC_EXIT_Click);
            // 
            // IDC_EXPLORER
            // 
            this.IDC_EXPLORER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_EXPLORER.Location = new System.Drawing.Point(29, 63);
            this.IDC_EXPLORER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_EXPLORER.MinimumSize = new System.Drawing.Size(15, 16);
            this.IDC_EXPLORER.Name = "IDC_EXPLORER";
            this.IDC_EXPLORER.Size = new System.Drawing.Size(655, 381);
            this.IDC_EXPLORER.TabIndex = 9;
            this.IDC_EXPLORER.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.IDC_EXPLORER_Navigated);
            this.IDC_EXPLORER.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.IDC_EXPLORER_Navigating);
            this.IDC_EXPLORER.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.IDC_EXPLORER_ProgressChanged);
            // 
            // IDC_PROGRESS
            // 
            this.IDC_PROGRESS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDC_PROGRESS.Location = new System.Drawing.Point(203, 458);
            this.IDC_PROGRESS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_PROGRESS.Name = "IDC_PROGRESS";
            this.IDC_PROGRESS.Size = new System.Drawing.Size(152, 19);
            this.IDC_PROGRESS.TabIndex = 10;
            // 
            // IDC_INP
            // 
            this.IDC_INP.Location = new System.Drawing.Point(292, 31);
            this.IDC_INP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_INP.Name = "IDC_INP";
            this.IDC_INP.Size = new System.Drawing.Size(75, 19);
            this.IDC_INP.TabIndex = 11;
            this.IDC_INP.Text = "Ввод";
            this.IDC_INP.UseVisualStyleBackColor = true;
            this.IDC_INP.Click += new System.EventHandler(this.IDC_INP_Click);
            // 
            // IDC_BACK
            // 
            this.IDC_BACK.Location = new System.Drawing.Point(410, 32);
            this.IDC_BACK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_BACK.Name = "IDC_BACK";
            this.IDC_BACK.Size = new System.Drawing.Size(56, 19);
            this.IDC_BACK.TabIndex = 12;
            this.IDC_BACK.Text = "Назад";
            this.IDC_BACK.UseVisualStyleBackColor = true;
            this.IDC_BACK.Click += new System.EventHandler(this.IDC_BACK_Click);
            // 
            // IDC_FORWARD
            // 
            this.IDC_FORWARD.Location = new System.Drawing.Point(516, 32);
            this.IDC_FORWARD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDC_FORWARD.Name = "IDC_FORWARD";
            this.IDC_FORWARD.Size = new System.Drawing.Size(56, 19);
            this.IDC_FORWARD.TabIndex = 13;
            this.IDC_FORWARD.Text = "Вперед";
            this.IDC_FORWARD.UseVisualStyleBackColor = true;
            this.IDC_FORWARD.Click += new System.EventHandler(this.IDC_FORWARD_Click);
            // 
            // expectionLbl
            // 
            this.expectionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expectionLbl.AutoSize = true;
            this.expectionLbl.Location = new System.Drawing.Point(26, 461);
            this.expectionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expectionLbl.Name = "expectionLbl";
            this.expectionLbl.Size = new System.Drawing.Size(38, 13);
            this.expectionLbl.TabIndex = 14;
            this.expectionLbl.Text = "Адрес";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 487);
            this.Controls.Add(this.expectionLbl);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Browser";
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
        private System.Windows.Forms.Label expectionLbl;
    }
}