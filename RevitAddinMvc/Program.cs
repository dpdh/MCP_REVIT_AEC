using System;
using System.Windows.Forms;
using Autodesk.Revit.UI;

namespace RevitAddinMvc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This is a placeholder - the actual addin is loaded by Revit
            // Application.ExternalStartup will handle the loading
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}