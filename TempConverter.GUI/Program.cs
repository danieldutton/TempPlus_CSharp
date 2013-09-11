using System;
using System.Windows.Forms;
using TempConverter.Model;
using TempConverter.Model.Domain;
using TempConverter.Model.Interfaces;

namespace TempConverter.GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ITemperatureConverter tempConverter = new TemperatureConverter();            
            
            //Scale set for weather not scientific
            var scale = new Scale<int> {Minimum = -150, Maximum = 150, ScaleBy = 3};
                      
            Application.Run(new Form1(tempConverter, scale));
        }
    }
}
