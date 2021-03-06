﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CommonTools;

namespace MyPaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Mailer.SilentSend("MyPaint Application Starts", "Some Using application", false);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Drawing());
            }
            catch (Exception ex)
            {
                Mailer.SilentSend("Exception Occurs", ex.ToString(), true);
            }
            Mailer.ShowFeedback();
        }
    }
}
