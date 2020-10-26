using ShN.DataModels;

namespace ShN
{
    partial class Editor
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
            this.m_redlst = new System.Windows.Forms.ListBox();
            this.IDC_NP1_STATIC = new System.Windows.Forms.Label();
            this.IDC_NM1_STATIC = new System.Windows.Forms.Label();
            this.IDC_ZR_STATIC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_n = new System.Windows.Forms.TextBox();
            this.IDC_ZC_STATIC = new System.Windows.Forms.Label();
            this.IDC_ZI_STATIC = new System.Windows.Forms.Label();
            this.m_z1 = new System.Windows.Forms.TextBox();
            this.m_np1 = new System.Windows.Forms.TextBox();
            this.m_nm1 = new System.Windows.Forms.TextBox();
            this.IDC_IN = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.IDC_OUT = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_redlst
            // 
            this.m_redlst.FormattingEnabled = true;
            this.m_redlst.Items.AddRange(new object[] {
            ElementType.Resistor,
            ElementType.Capacitor,
            ElementType.Inductor});
            this.m_redlst.Location = new System.Drawing.Point(9, 46);
            this.m_redlst.Margin = new System.Windows.Forms.Padding(2);
            this.m_redlst.Name = "m_redlst";
            this.m_redlst.Size = new System.Drawing.Size(122, 199);
            this.m_redlst.TabIndex = 0;
            this.m_redlst.DoubleClick += new System.EventHandler(this.m_redlst_DoubleClick);
            this.m_redlst.SelectedItem = ElementType.Resistor;
            // 
            // IDC_NP1_STATIC
            // 
            this.IDC_NP1_STATIC.AutoSize = true;
            this.IDC_NP1_STATIC.Location = new System.Drawing.Point(278, 69);
            this.IDC_NP1_STATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDC_NP1_STATIC.Name = "IDC_NP1_STATIC";
            this.IDC_NP1_STATIC.Size = new System.Drawing.Size(19, 13);
            this.IDC_NP1_STATIC.TabIndex = 1;
            this.IDC_NP1_STATIC.Text = "n+";
            // 
            // IDC_NM1_STATIC
            // 
            this.IDC_NM1_STATIC.AutoSize = true;
            this.IDC_NM1_STATIC.Location = new System.Drawing.Point(278, 98);
            this.IDC_NM1_STATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDC_NM1_STATIC.Name = "IDC_NM1_STATIC";
            this.IDC_NM1_STATIC.Size = new System.Drawing.Size(16, 13);
            this.IDC_NM1_STATIC.TabIndex = 2;
            this.IDC_NM1_STATIC.Text = "n-";
            // 
            // IDC_ZR_STATIC
            // 
            this.IDC_ZR_STATIC.AutoSize = true;
            this.IDC_ZR_STATIC.Location = new System.Drawing.Point(218, 125);
            this.IDC_ZR_STATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDC_ZR_STATIC.Name = "IDC_ZR_STATIC";
            this.IDC_ZR_STATIC.Size = new System.Drawing.Size(116, 13);
            this.IDC_ZR_STATIC.TabIndex = 3;
            this.IDC_ZR_STATIC.Text = "Сопротивление (кОм)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип компонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер компонента";
            // 
            // m_n
            // 
            this.m_n.Location = new System.Drawing.Point(281, 11);
            this.m_n.Margin = new System.Windows.Forms.Padding(2);
            this.m_n.Name = "m_n";
            this.m_n.Size = new System.Drawing.Size(76, 20);
            this.m_n.TabIndex = 6;
            this.m_n.Text = "1";
            // 
            // IDC_ZC_STATIC
            // 
            this.IDC_ZC_STATIC.AutoSize = true;
            this.IDC_ZC_STATIC.Location = new System.Drawing.Point(249, 125);
            this.IDC_ZC_STATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDC_ZC_STATIC.Name = "IDC_ZC_STATIC";
            this.IDC_ZC_STATIC.Size = new System.Drawing.Size(85, 13);
            this.IDC_ZC_STATIC.TabIndex = 12;
            this.IDC_ZC_STATIC.Text = "Ёмкость (мкФ)";
            // 
            // IDC_ZI_STATIC
            // 
            this.IDC_ZI_STATIC.AutoSize = true;
            this.IDC_ZI_STATIC.Location = new System.Drawing.Point(229, 125);
            this.IDC_ZI_STATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDC_ZI_STATIC.Name = "IDC_ZI_STATIC";
            this.IDC_ZI_STATIC.Size = new System.Drawing.Size(105, 13);
            this.IDC_ZI_STATIC.TabIndex = 13;
            this.IDC_ZI_STATIC.Text = "Индуктивность (Гн)";
            // 
            // m_z1
            // 
            this.m_z1.Location = new System.Drawing.Point(340, 122);
            this.m_z1.Margin = new System.Windows.Forms.Padding(2);
            this.m_z1.Name = "m_z1";
            this.m_z1.Size = new System.Drawing.Size(48, 20);
            this.m_z1.TabIndex = 19;
            // 
            // m_np1
            // 
            this.m_np1.Location = new System.Drawing.Point(340, 66);
            this.m_np1.Margin = new System.Windows.Forms.Padding(2);
            this.m_np1.Name = "m_np1";
            this.m_np1.Size = new System.Drawing.Size(50, 20);
            this.m_np1.TabIndex = 25;
            // 
            // m_nm1
            // 
            this.m_nm1.Location = new System.Drawing.Point(340, 95);
            this.m_nm1.Margin = new System.Windows.Forms.Padding(2);
            this.m_nm1.Name = "m_nm1";
            this.m_nm1.Size = new System.Drawing.Size(50, 20);
            this.m_nm1.TabIndex = 26;
            // 
            // IDC_IN
            // 
            this.IDC_IN.Location = new System.Drawing.Point(232, 287);
            this.IDC_IN.Margin = new System.Windows.Forms.Padding(2);
            this.IDC_IN.Name = "IDC_IN";
            this.IDC_IN.Size = new System.Drawing.Size(93, 19);
            this.IDC_IN.TabIndex = 27;
            this.IDC_IN.Text = "Ввод описания";
            this.IDC_IN.UseVisualStyleBackColor = true;
            this.IDC_IN.Click += new System.EventHandler(this.IDC_IN_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(27, 287);
            this.OK.Margin = new System.Windows.Forms.Padding(2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(56, 19);
            this.OK.TabIndex = 28;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IDC_OUT
            // 
            this.IDC_OUT.Location = new System.Drawing.Point(221, 37);
            this.IDC_OUT.Margin = new System.Windows.Forms.Padding(2);
            this.IDC_OUT.Name = "IDC_OUT";
            this.IDC_OUT.Size = new System.Drawing.Size(104, 19);
            this.IDC_OUT.TabIndex = 29;
            this.IDC_OUT.Text = "Вывод описания";
            this.IDC_OUT.UseVisualStyleBackColor = true;
            this.IDC_OUT.Click += new System.EventHandler(this.IDC_OUT_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(164, 169);
            this.infoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 13);
            this.infoLbl.TabIndex = 30;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 315);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.IDC_OUT);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.IDC_IN);
            this.Controls.Add(this.m_nm1);
            this.Controls.Add(this.m_np1);
            this.Controls.Add(this.m_z1);
            this.Controls.Add(this.IDC_ZI_STATIC);
            this.Controls.Add(this.IDC_ZC_STATIC);
            this.Controls.Add(this.m_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDC_ZR_STATIC);
            this.Controls.Add(this.IDC_NM1_STATIC);
            this.Controls.Add(this.IDC_NP1_STATIC);
            this.Controls.Add(this.m_redlst);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Editor";
            this.Text = "Редактирование компонентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_redlst;
        private System.Windows.Forms.Label IDC_NP1_STATIC;
        private System.Windows.Forms.Label IDC_NM1_STATIC;
        private System.Windows.Forms.Label IDC_ZR_STATIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_n;
        private System.Windows.Forms.Label IDC_ZC_STATIC;
        private System.Windows.Forms.Label IDC_ZI_STATIC;
        private System.Windows.Forms.TextBox m_z1;
        private System.Windows.Forms.TextBox m_np1;
        private System.Windows.Forms.TextBox m_nm1;
        private System.Windows.Forms.Button IDC_IN;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button IDC_OUT;
        private System.Windows.Forms.Label infoLbl;
    }
}