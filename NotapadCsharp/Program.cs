using System;
using System.Windows.Forms;

namespace NotapadCsharp
{
    static class Program
    {
        public static IndexForm IndexForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IndexForm = new IndexForm();
            Application.Run(IndexForm);
        }
    }
}