using System;
using System.Windows.Forms;

namespace PDF_Protector_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            Application.Run(new PDF_Protector());
        }
    }
}
