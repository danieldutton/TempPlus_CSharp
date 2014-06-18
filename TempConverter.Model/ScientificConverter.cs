using System;
using TempConverter.Model.Interfaces;

namespace TempConverter.Model
{
    public class ScientificConverter : ITemperatureConverter
    {
        public static ConversionFormula KelvinToRankine = t => (t * 1.8);

        public static ConversionFormula KelvinToReaumur = t => (t - 273.15) * 0.8;

        public static ConversionFormula RankineToReaumur = t => ((t - 32 - 459.67) / 2.25);  

        public static ConversionFormula RankineToKelvin = t => (t / 1.8);

        public static ConversionFormula ReaumurToRankine = t => (t * 2.25 + 32 + 459.67);

        public static ConversionFormula ReaumurToKelvin = t => (t * 1.25 + 273.15);

        
        public double Convert(double temperature, ConversionFormula conversionFormula, int roundBy = 0)
        {
            return Math.Round(conversionFormula(temperature), roundBy);
        }
    }
}
