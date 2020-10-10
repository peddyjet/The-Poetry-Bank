using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Poetry_Bank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        const string ORIGIN_PATH = @"https://raw.githubusercontent.com/lewisjet/The-Poetry-Bank/master/Links";

        [STAThread]
        static void Main()
        {
           string result = Caches.Setup(ORIGIN_PATH);
           if (result != string.Empty) { Failiure(result); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());
        }

        private static void Failiure(string msg)
        {
            MessageBox.Show($"A fatal error has occured: {msg}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
