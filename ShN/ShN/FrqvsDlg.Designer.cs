namespace ShN
{
    partial class FrqvsDlg
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_DESC = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CONS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_RED = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_DIR = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_F = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_IO = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_TYPE = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_PRIV = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_SYS = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_CALC = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_INTERNET = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsLbl = new System.Windows.Forms.Label();
            this.selectParametersFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MENU
            // 
            this.MENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_DESC,
            this.ID_RED,
            this.ID_DIR,
            this.ID_TYPE,
            this.ID_CALC,
            this.ID_INTERNET,
            this.ID_EXIT});
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(53, 20);
            this.MENU.Text = "Меню";
            // 
            // ID_DESC
            // 
            this.ID_DESC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_CONS,
            this.ID_FILE});
            this.ID_DESC.Name = "ID_DESC";
            this.ID_DESC.Size = new System.Drawing.Size(181, 22);
            this.ID_DESC.Text = "Описание";
            // 
            // ID_CONS
            // 
            this.ID_CONS.Name = "ID_CONS";
            this.ID_CONS.Size = new System.Drawing.Size(177, 22);
            this.ID_CONS.Text = "Ввод с клавиатуры";
            this.ID_CONS.Click += new System.EventHandler(this.ID_CONS_Click);
            // 
            // ID_FILE
            // 
            this.ID_FILE.Name = "ID_FILE";
            this.ID_FILE.Size = new System.Drawing.Size(177, 22);
            this.ID_FILE.Text = "Ввод из файла";
            this.ID_FILE.Click += new System.EventHandler(this.ID_FILE_Click);
            // 
            // ID_RED
            // 
            this.ID_RED.Name = "ID_RED";
            this.ID_RED.Size = new System.Drawing.Size(181, 22);
            this.ID_RED.Text = "Редактирование";
            this.ID_RED.Click += new System.EventHandler(this.ID_RED_Click);
            // 
            // ID_DIR
            // 
            this.ID_DIR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_F,
            this.ID_IO});
            this.ID_DIR.Name = "ID_DIR";
            this.ID_DIR.Size = new System.Drawing.Size(181, 22);
            this.ID_DIR.Text = "Директивы расчёта";
            // 
            // ID_F
            // 
            this.ID_F.Name = "ID_F";
            this.ID_F.Size = new System.Drawing.Size(244, 22);
            this.ID_F.Text = "Вид частотной характеристики";
            this.ID_F.Click += new System.EventHandler(this.ID_F_Click);
            // 
            // ID_IO
            // 
            this.ID_IO.Name = "ID_IO";
            this.ID_IO.Size = new System.Drawing.Size(244, 22);
            this.ID_IO.Text = "Вх/вых узлы";
            this.ID_IO.Click += new System.EventHandler(this.ID_IO_Click);
            // 
            // ID_TYPE
            // 
            this.ID_TYPE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_PRIV,
            this.ID_SYS});
            this.ID_TYPE.Name = "ID_TYPE";
            this.ID_TYPE.Size = new System.Drawing.Size(181, 22);
            this.ID_TYPE.Text = "Вид";
            // 
            // ID_PRIV
            // 
            this.ID_PRIV.Name = "ID_PRIV";
            this.ID_PRIV.Size = new System.Drawing.Size(196, 22);
            this.ID_PRIV.Text = "Собственный браузер";
            // 
            // ID_SYS
            // 
            this.ID_SYS.Name = "ID_SYS";
            this.ID_SYS.Size = new System.Drawing.Size(196, 22);
            this.ID_SYS.Text = "Системный браузер";
            // 
            // ID_CALC
            // 
            this.ID_CALC.Name = "ID_CALC";
            this.ID_CALC.Size = new System.Drawing.Size(181, 22);
            this.ID_CALC.Text = "Расчёт";
            // 
            // ID_INTERNET
            // 
            this.ID_INTERNET.Name = "ID_INTERNET";
            this.ID_INTERNET.Size = new System.Drawing.Size(181, 22);
            this.ID_INTERNET.Text = "Интернет";
            // 
            // ID_EXIT
            // 
            this.ID_EXIT.Name = "ID_EXIT";
            this.ID_EXIT.Size = new System.Drawing.Size(181, 22);
            this.ID_EXIT.Text = "Выход";
            this.ID_EXIT.Click += new System.EventHandler(this.ID_EXIT_Click);
            // 
            // paramsLbl
            // 
            this.paramsLbl.AutoSize = true;
            this.paramsLbl.Location = new System.Drawing.Point(13, 46);
            this.paramsLbl.Name = "paramsLbl";
            this.paramsLbl.Size = new System.Drawing.Size(35, 13);
            this.paramsLbl.TabIndex = 1;
            this.paramsLbl.Text = "label1";
            // 
            // selectParametersFileDialog
            // 
            this.selectParametersFileDialog.FileName = "selectParametersFileDialog";
            // 
            // FrqvsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 242);
            this.Controls.Add(this.paramsLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrqvsDlg";
            this.Text = "Моделирование непрерывных систем";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MENU;
        private System.Windows.Forms.ToolStripMenuItem ID_DESC;
        private System.Windows.Forms.ToolStripMenuItem ID_CONS;
        private System.Windows.Forms.ToolStripMenuItem ID_FILE;
        private System.Windows.Forms.ToolStripMenuItem ID_RED;
        private System.Windows.Forms.ToolStripMenuItem ID_DIR;
        private System.Windows.Forms.ToolStripMenuItem ID_F;
        private System.Windows.Forms.ToolStripMenuItem ID_IO;
        private System.Windows.Forms.ToolStripMenuItem ID_TYPE;
        private System.Windows.Forms.ToolStripMenuItem ID_PRIV;
        private System.Windows.Forms.ToolStripMenuItem ID_SYS;
        private System.Windows.Forms.ToolStripMenuItem ID_CALC;
        private System.Windows.Forms.ToolStripMenuItem ID_INTERNET;
        private System.Windows.Forms.ToolStripMenuItem ID_EXIT;
        private System.Windows.Forms.Label paramsLbl;
        private System.Windows.Forms.OpenFileDialog selectParametersFileDialog;
    }
}

