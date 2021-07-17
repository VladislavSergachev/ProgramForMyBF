﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyTrainer
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

            trainerBase.InitMainWin();
            
            Application.Run(trainerBase.MainFrame);
        }
    }
}
