﻿using NLog;
using System;
using System.Windows.Forms;
using ToDoApp.Services;

namespace ToDoApp.Forms
{
    internal static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Logger.Info("Application started");
            NotificationService.Instance.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}