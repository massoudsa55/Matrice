using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMatrice
{
    static class Program
    {
        public static int ligne1, ligne2, colonne1, colonne2;  
        public static string Opération, Description;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
