namespace TempConverter.Model.Interfaces
{
    public interface ITemperatureConverter
    {
        double ConvertTemperature(double temperatureValue, ConversionFormula conversionFormula, int roundBy);
    }
}
