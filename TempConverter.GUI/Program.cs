using System;
using System.Windows.Forms;
using TempConverter.Model;

namespace TempConverter.GUI
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            //For UI thread exceptions
            Application.ThreadException += GlobalExceptionHandler;

            //Force all Windows Forms errors to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //For non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var tempConverter = new StandardConverter();

            Application.Run(new Console(tempConverter));
        }


        private static void GlobalExceptionHandler(object sender, System.EventArgs args)
        {
            MessageBox.Show("There was a problem with the application.  Please contact the author");
            Application.Exit();
        }
    }
}
