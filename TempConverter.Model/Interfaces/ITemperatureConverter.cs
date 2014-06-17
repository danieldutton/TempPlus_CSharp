namespace TempConverter.Model.Interfaces
{
    public interface ITemperatureConverter
    {
        double Convert(double temperature, ConversionFormula conversionFormula, int roundBy = 0);
    }
}
