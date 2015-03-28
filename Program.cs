using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MathKeyBoard;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainKeyboard());
           // Application.Run(new SetTheory_Logic());
           // Application.Run(new SetTheory());
            // Application.Run(new Form1());
            
        }
    }
}
