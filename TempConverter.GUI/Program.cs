using System;
using System.Windows.Forms;
using TempConverter.Model;
using TempConverter.Model.Domain;
using TempConverter.Model.Interfaces;

namespace TempConverter.GUI
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ITemperatureConverter tempConverter = new TemperatureConverter();

            var scale = new Scale<int>(minimum: -150, maximum: 150, scaleBy: 3);
                      
            Application.Run(new Console(tempConverter, scale));
        }
    }
}
