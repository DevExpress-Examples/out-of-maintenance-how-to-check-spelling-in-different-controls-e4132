using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpellCheckerInheritedControls {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            SpellCheckerRegistrationHelper.RegisterCustomControlsForSpellChecking();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}