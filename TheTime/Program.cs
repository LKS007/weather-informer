﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TheTime
{
    static class Program
    {

        public static DataWorkerDataContext data = new DataWorkerDataContext();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
