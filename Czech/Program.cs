using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Czech
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PublicClass publicClass = new PublicClass();
            Application.Run(new Form1());
        }
    }
}
