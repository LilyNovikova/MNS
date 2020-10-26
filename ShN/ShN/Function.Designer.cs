namespace ShN
{
    partial class Function
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
            this.IDC_F = new System.Windows.Forms.RadioButton();
            this.DF = new System.Windows.Forms.RadioButton();
            this.KF = new System.Windows.Forms.RadioButton();
            this.IDC_T1 = new System.Windows.Forms.TextBox();
            this.IDC_T2 = new System.Windows.Forms.TextBox();
            this.IDC_T3 = new System.Windows.Forms.TextBox();
            this.IDC_F1 = new System.Windows.Forms.TextBox();
            this.IDC_F2 = new System.Windows.Forms.TextBox();
            this.IDC_F3 = new System.Windows.Forms.TextBox();
            this.IDC_FOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDC_F
            // 
            this.IDC_F.AutoSize = true;
            this.IDC_F.Checked = true;
            this.IDC_F.Location = new System.Drawing.Point(37, 26);
            this.IDC_F.Name = "IDC_F";
            this.IDC_F.Size = new System.Drawing.Size(238, 21);
            this.IDC_F.TabIndex = 0;
            this.IDC_F.TabStop = true;
            this.IDC_F.Text = "Единственная частотная точка";
            this.IDC_F.UseVisualStyleBackColor = true;
            this.IDC_F.CheckedChanged += new System.EventHandler(this.IDC_F_CheckedChanged);
            // 
            // DF
            // 
            this.DF.AutoSize = true;
            this.DF.Location = new System.Drawing.Point(37, 70);
            this.DF.Name = "DF";
            this.DF.Size = new System.Drawing.Size(266, 21);
            this.DF.TabIndex = 1;
            this.DF.Text = "Линйный закон изменения частоты";
            this.DF.UseVisualStyleBackColor = true;
            this.DF.CheckedChanged += new System.EventHandler(this.DF_CheckedChanged);
            // 
            // KF
            // 
            this.KF.AutoSize = true;
            this.KF.Location = new System.Drawing.Point(37, 118);
            this.KF.Name = "KF";
            this.KF.Size = new System.Drawing.Size(327, 21);
            this.KF.TabIndex = 2;
            this.KF.Text = "Логарифмический закон изменения частоты";
            this.KF.UseVisualStyleBackColor = true;
            this.KF.CheckedChanged += new System.EventHandler(this.KF_CheckedChanged);
            // 
            // IDC_T1
            // 
            this.IDC_T1.Location = new System.Drawing.Point(37, 176);
            this.IDC_T1.Name = "IDC_T1";
            this.IDC_T1.ReadOnly = true;
            this.IDC_T1.Size = new System.Drawing.Size(219, 22);
            this.IDC_T1.TabIndex = 3;
            this.IDC_T1.Text = "Значение частоты (кгц)";
            // 
            // IDC_T2
            // 
            this.IDC_T2.Location = new System.Drawing.Point(37, 219);
            this.IDC_T2.Name = "IDC_T2";
            this.IDC_T2.ReadOnly = true;
            this.IDC_T2.Size = new System.Drawing.Size(219, 22);
            this.IDC_T2.TabIndex = 4;
            // 
            // IDC_T3
            // 
            this.IDC_T3.Location = new System.Drawing.Point(37, 266);
            this.IDC_T3.Name = "IDC_T3";
            this.IDC_T3.ReadOnly = true;
            this.IDC_T3.Size = new System.Drawing.Size(219, 22);
            this.IDC_T3.TabIndex = 5;
            // 
            // IDC_F1
            // 
            this.IDC_F1.Location = new System.Drawing.Point(307, 176);
            this.IDC_F1.Name = "IDC_F1";
            this.IDC_F1.Size = new System.Drawing.Size(100, 22);
            this.IDC_F1.TabIndex = 6;
            this.IDC_F1.Text = "0";
            // 
            // IDC_F2
            // 
            this.IDC_F2.Location = new System.Drawing.Point(307, 219);
            this.IDC_F2.Name = "IDC_F2";
            this.IDC_F2.Size = new System.Drawing.Size(100, 22);
            this.IDC_F2.TabIndex = 7;
            this.IDC_F2.Text = "0";
            // 
            // IDC_F3
            // 
            this.IDC_F3.Location = new System.Drawing.Point(308, 267);
            this.IDC_F3.Name = "IDC_F3";
            this.IDC_F3.Size = new System.Drawing.Size(100, 22);
            this.IDC_F3.TabIndex = 8;
            this.IDC_F3.Text = "0";
            // 
            // IDC_FOK_BUTTON
            // 
            this.IDC_FOK_BUTTON.Location = new System.Drawing.Point(173, 324);
            this.IDC_FOK_BUTTON.Name = "IDC_FOK_BUTTON";
            this.IDC_FOK_BUTTON.Size = new System.Drawing.Size(128, 23);
            this.IDC_FOK_BUTTON.TabIndex = 9;
            this.IDC_FOK_BUTTON.Text = "OK";
            this.IDC_FOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FOK_BUTTON.Click += new System.EventHandler(this.IDC_FOK_BUTTON_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 396);
            this.Controls.Add(this.IDC_FOK_BUTTON);
            this.Controls.Add(this.IDC_F3);
            this.Controls.Add(this.IDC_F2);
            this.Controls.Add(this.IDC_F1);
            this.Controls.Add(this.IDC_T3);
            this.Controls.Add(this.IDC_T2);
            this.Controls.Add(this.IDC_T1);
            this.Controls.Add(this.KF);
            this.Controls.Add(this.DF);
            this.Controls.Add(this.IDC_F);
            this.Name = "F";
            this.Text = "Вид частотной характеристики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IDC_F;
        private System.Windows.Forms.RadioButton DF;
        private System.Windows.Forms.RadioButton KF;
        private System.Windows.Forms.TextBox IDC_T1;
        private System.Windows.Forms.TextBox IDC_T2;
        private System.Windows.Forms.TextBox IDC_T3;
        private System.Windows.Forms.TextBox IDC_F1;
        private System.Windows.Forms.TextBox IDC_F2;
        private System.Windows.Forms.TextBox IDC_F3;
        private System.Windows.Forms.Button IDC_FOK_BUTTON;
    }
}