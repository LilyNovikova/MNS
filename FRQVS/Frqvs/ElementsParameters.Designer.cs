namespace Frqvs
{
    partial class ElementsParameters
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
            this.label3 = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.m_nextr = new System.Windows.Forms.TextBox();
            this.m_npr = new System.Windows.Forms.TextBox();
            this.m_nmr = new System.Windows.Forms.TextBox();
            this.m_zr = new System.Windows.Forms.TextBox();
            this.elementTypeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Location = new System.Drawing.Point(39, 135);
            this.valueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(116, 13);
            this.valueLbl.TabIndex = 3;
            this.valueLbl.Text = "Сопротивление (кОм)";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(116, 177);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(78, 19);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Следующий";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // m_nextr
            // 
            this.m_nextr.Location = new System.Drawing.Point(171, 47);
            this.m_nextr.Margin = new System.Windows.Forms.Padding(2);
            this.m_nextr.Name = "m_nextr";
            this.m_nextr.ReadOnly = true;
            this.m_nextr.Size = new System.Drawing.Size(76, 20);
            this.m_nextr.TabIndex = 5;
            this.m_nextr.Text = "1";
            // 
            // m_npr
            // 
            this.m_npr.Location = new System.Drawing.Point(171, 76);
            this.m_npr.Margin = new System.Windows.Forms.Padding(2);
            this.m_npr.Name = "m_npr";
            this.m_npr.Size = new System.Drawing.Size(76, 20);
            this.m_npr.TabIndex = 6;
            this.m_npr.Text = "0";
            // 
            // m_nmr
            // 
            this.m_nmr.Location = new System.Drawing.Point(171, 104);
            this.m_nmr.Margin = new System.Windows.Forms.Padding(2);
            this.m_nmr.Name = "m_nmr";
            this.m_nmr.Size = new System.Drawing.Size(76, 20);
            this.m_nmr.TabIndex = 7;
            this.m_nmr.Text = "0";
            // 
            // m_zr
            // 
            this.m_zr.Location = new System.Drawing.Point(171, 135);
            this.m_zr.Margin = new System.Windows.Forms.Padding(2);
            this.m_zr.Name = "m_zr";
            this.m_zr.Size = new System.Drawing.Size(76, 20);
            this.m_zr.TabIndex = 8;
            this.m_zr.Text = "0";
            // 
            // elementTypeTxt
            // 
            this.elementTypeTxt.Location = new System.Drawing.Point(171, 18);
            this.elementTypeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.elementTypeTxt.Name = "elementTypeTxt";
            this.elementTypeTxt.ReadOnly = true;
            this.elementTypeTxt.Size = new System.Drawing.Size(76, 20);
            this.elementTypeTxt.TabIndex = 10;
            this.elementTypeTxt.Text = "Resistor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип";
            // 
            // ElementsParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 219);
            this.Controls.Add(this.elementTypeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_zr);
            this.Controls.Add(this.m_nmr);
            this.Controls.Add(this.m_npr);
            this.Controls.Add(this.m_nextr);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElementsParameters";
            this.Text = "Описание элементов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox m_nextr;
        private System.Windows.Forms.TextBox m_npr;
        private System.Windows.Forms.TextBox m_nmr;
        private System.Windows.Forms.TextBox m_zr;
        private System.Windows.Forms.TextBox elementTypeTxt;
        private System.Windows.Forms.Label label4;
    }
}