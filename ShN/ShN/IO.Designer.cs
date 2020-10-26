namespace ShN
{
    partial class IO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDC_IOOK_BUTTON = new System.Windows.Forms.Button();
            this.m_lp = new System.Windows.Forms.TextBox();
            this.m_lm = new System.Windows.Forms.TextBox();
            this.m_kp = new System.Windows.Forms.TextBox();
            this.m_km = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные узлы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выходные узлы";
            // 
            // IDC_IOOK_BUTTON
            // 
            this.IDC_IOOK_BUTTON.Location = new System.Drawing.Point(171, 208);
            this.IDC_IOOK_BUTTON.Name = "IDC_IOOK_BUTTON";
            this.IDC_IOOK_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_IOOK_BUTTON.TabIndex = 2;
            this.IDC_IOOK_BUTTON.Text = "OK";
            this.IDC_IOOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_IOOK_BUTTON.Click += new System.EventHandler(this.IDC_IOOK_BUTTON_Click);
            // 
            // m_lp
            // 
            this.m_lp.Location = new System.Drawing.Point(23, 62);
            this.m_lp.Name = "m_lp";
            this.m_lp.Size = new System.Drawing.Size(100, 22);
            this.m_lp.TabIndex = 3;
            this.m_lp.Text = "0";
            // 
            // m_lm
            // 
            this.m_lm.Location = new System.Drawing.Point(23, 119);
            this.m_lm.Name = "m_lm";
            this.m_lm.Size = new System.Drawing.Size(100, 22);
            this.m_lm.TabIndex = 4;
            this.m_lm.Text = "0";
            // 
            // m_kp
            // 
            this.m_kp.Location = new System.Drawing.Point(219, 61);
            this.m_kp.Name = "m_kp";
            this.m_kp.Size = new System.Drawing.Size(100, 22);
            this.m_kp.TabIndex = 5;
            this.m_kp.Text = "0";
            // 
            // m_km
            // 
            this.m_km.Location = new System.Drawing.Point(219, 119);
            this.m_km.Name = "m_km";
            this.m_km.Size = new System.Drawing.Size(100, 22);
            this.m_km.TabIndex = 6;
            this.m_km.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "l+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "l-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "k+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "k-";
            // 
            // IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_km);
            this.Controls.Add(this.m_kp);
            this.Controls.Add(this.m_lm);
            this.Controls.Add(this.m_lp);
            this.Controls.Add(this.IDC_IOOK_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IO";
            this.Text = "Входные и выходные узлы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IDC_IOOK_BUTTON;
        private System.Windows.Forms.TextBox m_lp;
        private System.Windows.Forms.TextBox m_lm;
        private System.Windows.Forms.TextBox m_kp;
        private System.Windows.Forms.TextBox m_km;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}