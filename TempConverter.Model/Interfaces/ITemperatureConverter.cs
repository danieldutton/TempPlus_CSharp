namespace TempConverter.Model.Interfaces
{
    public interface ITemperatureConverter
    {
        double ConvertTemperature(double temperature, ConversionFormula conversionFormula, int roundBy = 0);
    }
}
