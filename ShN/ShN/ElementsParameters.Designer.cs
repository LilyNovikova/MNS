namespace ShN
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
            this.lblId = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.elementId = new System.Windows.Forms.TextBox();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.elementTypeTxt = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 47);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(37, 76);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(19, 13);
            this.label0.TabIndex = 1;
            this.label0.Text = "n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сопротивление (кОм)";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(118, 362);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(78, 19);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Следующий";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // elementId
            // 
            this.elementId.Location = new System.Drawing.Point(171, 47);
            this.elementId.Margin = new System.Windows.Forms.Padding(2);
            this.elementId.Name = "elementId";
            this.elementId.ReadOnly = true;
            this.elementId.Size = new System.Drawing.Size(76, 20);
            this.elementId.TabIndex = 5;
            this.elementId.Text = "1";
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(171, 76);
            this.txt0.Margin = new System.Windows.Forms.Padding(2);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(76, 20);
            this.txt0.TabIndex = 6;
            this.txt0.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(171, 104);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(76, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "0";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(171, 135);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(76, 20);
            this.txt2.TabIndex = 8;
            this.txt2.Text = "0";
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(35, 18);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Тип";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(171, 168);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(76, 20);
            this.txt3.TabIndex = 12;
            this.txt3.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сопротивление (кОм)";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(171, 200);
            this.txt4.Margin = new System.Windows.Forms.Padding(2);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(76, 20);
            this.txt4.TabIndex = 14;
            this.txt4.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сопротивление (кОм)";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(171, 232);
            this.txt5.Margin = new System.Windows.Forms.Padding(2);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(76, 20);
            this.txt5.TabIndex = 16;
            this.txt5.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Сопротивление (кОм)";
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(171, 264);
            this.txt6.Margin = new System.Windows.Forms.Padding(2);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(76, 20);
            this.txt6.TabIndex = 18;
            this.txt6.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Сопротивление (кОм)";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(171, 296);
            this.txt7.Margin = new System.Windows.Forms.Padding(2);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(76, 20);
            this.txt7.TabIndex = 20;
            this.txt7.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Сопротивление (кОм)";
            // 
            // ElementsParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 392);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elementTypeTxt);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.elementId);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElementsParameters";
            this.Text = "Описание элементов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox elementId;
        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox elementTypeTxt;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Label label7;
    }
}