using System;
using System.Windows.Forms;

namespace ShortURLCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ops!!, an error has ocurred, sorry for this inconvenient" + Environment.NewLine + Environment.NewLine + "Error Description: " + e.Exception.Message);
        }
    }
}
