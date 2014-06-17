using NUnit.Framework;
using TempConverter.Model;

namespace TempConverter.UnitTests.Celsius.ToDecimalPlace_0
{
    [TestFixture]
    public class TemperatureConverter_C_To_F_Should
    {
        private ConversionFormula _celsiusToFahrenheit;

        private StandardConverter _standardConverter;

        private const int RoundBy = 0;


        [SetUp]
        public void Init()
        {
            _celsiusToFahrenheit = StandardConverter.CelsiusToFahrenheit;
            _standardConverter = new StandardConverter();
        }

        #region Celsius To Fahrenheit Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_0_To_10_RoundedTo0DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(32, 34, 36, 37, 39, 41, 43, 45, 46, 48, 50)]double expected)
        {          
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_11_To_20_RoundedTo0DP([Range(11d, 20d, 1d)]double temperature,
                    [Values(52, 54, 55, 57, 59, 61, 63, 64, 66, 68)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_21_To_30_RoundedTo0DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(70, 72, 73, 75, 77, 79, 81, 82, 84, 86)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_31_To_40_RoundedTo0DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(88, 90, 91, 93, 95, 97, 99, 100, 102, 104)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_41_To_50_RoundedTo0DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(106, 108, 109, 111, 113, 115, 117, 118, 120, 122)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_51_To_60_RoundedTo0DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(124, 126, 127, 129, 131, 133, 135, 136, 138, 140)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_61_To_70_RoundedTo0DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(142, 144, 145, 147, 149, 151, 153, 154, 156, 158)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        
        #endregion

        #region Celsius To Fahrenheit Negative Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg100_To_Neg90_RoundedTo0DP([Range(-100d, -90d, 1d)]double temperature,
                    [Values(-148, -146, -144, -143, -141, -139, -137, -135, -134, -132, -130)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg89_To_Neg80_RoundedTo0DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-128, -126, -125, -123, -121, -119, -117, -116, -114, -112)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg79_To_Neg70_RoundedTo0DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-110, -108, -107, -105, -103, -101, -99, -98, -96, -94)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg69_To_Neg60_RoundedTo0DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-92, -90, -89, -87, -85, -83, -81, -80, -78, -76)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg59_To_Neg50_RoundedTo0DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-74, -72, -71, -69, -67, -65, -63, -62, -60, -58)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg49_To_Neg40_RoundedTo0DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-56, -54, -53,-51, -49, -47, -45, -44, -42, -40)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg39_To_Neg30_RoundedTo0DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-38, -36, -35, -33, -31, -29, -27, -26, -24, -22)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg29_To_Neg20_RoundedTo0DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-20, -18, -17, -15, -13, -11, -9, -8, -6, -4)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg19_To_Neg10_RoundedTo0DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-2, -0, 1, 3, 5, 7, 9, 10,12, 14)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg9_To_0_RoundedTo0DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(16, 18, 19, 21, 23, 25, 27, 28, 30, 32)]double expected)
        {
            double actual = _standardConverter.ConvertTemperature(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _celsiusToFahrenheit = null;
            _standardConverter = null;
        }
    }
}
