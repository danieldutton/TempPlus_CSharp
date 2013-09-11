using System;
using TempConverter.Model.Interfaces;

namespace TempConverter.Model
{
    public class TemperatureConverter : ITemperatureConverter
    {
        public static ConversionFormula CelsiusToFahrenheit = t => ((t * 1.8) + 32);
        
        public static ConversionFormula CelsiusToKelvin = t => (t + 273);

        public static ConversionFormula FahrenheitToCelsius = t => ((t - 32) * 5/9);

        public static ConversionFormula FahrenheitToKelvin = t => (t + 459.67)/1.8;

        public static ConversionFormula KelvinToCelsius = t => (t - 273);

        public static ConversionFormula KelvinToFahrenheit = t => (t * 9/5 - 459.67);


        public double ConvertTemperature(double temperatureValue, ConversionFormula conversionFormula, int roundBy = 0)
        {           
            return Math.Round(conversionFormula(temperatureValue), roundBy);
        }
    }
}
