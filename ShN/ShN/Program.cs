﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ShN
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrqvsDlg());
        }
    }
}
