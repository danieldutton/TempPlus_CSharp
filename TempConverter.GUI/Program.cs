using System;
using System.Windows.Forms;
using TempConverter.GUI.Components;
using TempConverter.Model;
using TempConverter.Model.Domain;

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
            var noFocusTrackBar = new NoFocusTrackBar(new Scale<int>(minimum: -220, maximum: 220, scaleBy: 5));

            Application.Run(new Console(tempConverter, noFocusTrackBar));
        }


        private static void GlobalExceptionHandler(object sender, System.EventArgs args)
        {
            MessageBox.Show("There was a problem with the application.  Please contact the author");
            Application.Exit();
        }
    }
}
