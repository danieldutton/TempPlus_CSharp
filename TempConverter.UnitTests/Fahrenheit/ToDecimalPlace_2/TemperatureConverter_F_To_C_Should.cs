using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Fahrenheit.ToDecimalPlace_2
{
    [TestFixture]
    public class TemperatureConverter_F_To_C_Should
    {
        private ConversionFormula _fahrenheitToCelsius;

        private ITemperatureConverter _temperatureConverter;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _fahrenheitToCelsius = TemperatureConverter.FahrenheitToCelsius;
            _temperatureConverter = new TemperatureConverter();
        }

        #region Fahrenheit To Celsius Positive Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_0_To_10_RoundedTo2DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(-17.78, -17.22, -16.67, -16.11, -15.56, -15, -14.44, -13.89, -13.33, -12.78, -12.22)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_11_To_20_RoundedTo2DP([Range(11.0d, 20d, 1d)]double temperature,
                    [Values(-11.67, -11.11, -10.56, -10, -9.44, -8.89, -8.33, -7.78, -7.22, -6.67)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_21_To_30_RoundedTo2DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(-6.11, -5.56, -5, -4.44, -3.89, -3.33, -2.78, -2.22, -1.67, -1.11)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_31_To_40_RoundedTo2DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(-0.56, 0, 0.56, 1.11, 1.67, 2.22, 2.78, 3.33, 3.89, 4.44)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_41_To_50_RoundedTo2DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(5, 5.56, 6.11, 6.67, 7.22, 7.78, 8.33, 8.89, 9.44, 10)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_51_To_60_RoundedTo2DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(10.56, 11.11, 11.67, 12.22, 12.78, 13.33, 13.89, 14.44, 15, 15.56)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_61_To_70_RoundedTo2DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(16.11, 16.67, 17.22, 17.78, 18.33, 18.89, 19.44, 20, 20.56, 21.11)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_71_To_80_RoundedTo2DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(21.67, 22.22, 22.78, 23.33, 23.89, 24.44, 25, 25.56, 26.11, 26.67)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_81_To_90_RoundedTo2DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(27.22, 27.78, 28.33, 28.89, 29.44, 30, 30.56, 31.11, 31.67, 32.22)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_91_To_100_RoundedTo2DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(32.78, 33.33, 33.89, 34.44, 35, 35.56, 36.11, 36.67, 37.22, 37.78)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_101_To_110_RoundedTo2DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(38.33, 38.89, 39.44, 40, 40.56, 41.11, 41.67, 42.22, 42.78, 43.33)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_111_To_120_RoundedTo2DP([Range(111d, 120d, 1d)]double temperature,
                    [Values(43.89, 44.44, 45, 45.56, 46.11, 46.67, 47.22, 47.78, 48.33, 48.89)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_121_To_130_RoundedTo2DP([Range(121d, 130d, 1d)]double temperature,
                    [Values(49.44, 50, 50.56, 51.11, 51.67, 52.22, 52.78, 53.33, 53.89, 54.44)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_131_To_140_RoundedTo2DP([Range(131d, 140d, 1d)]double temperature,
                    [Values(55, 55.56, 56.11, 56.67, 57.22, 57.78, 58.33, 58.89, 59.44, 60)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_141_To_150_RoundedTo2DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(60.56, 61.11, 61.67, 62.22, 62.78, 63.33, 63.89, 64.44, 65, 65.56)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        #region Fahrenheit To Celsius Negative Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg150_To_Neg140_RoundedTo2DP([Range(-150d, -140d, 1d)]double temperature,
                    [Values(-101.11, -100.56, -100, -99.44, -98.89, -98.33, -97.78, -97.22, -96.67, -96.11, -95.56)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg139_To_Neg130_RoundedTo2DP([Range(-139d, -130d, 1d)]double temperature,
                    [Values(-95, -94.44, -93.89, -93.33, -92.78, -92.22, -91.67, -91.11, -90.56, -90)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg129_To_Neg120_RoundedTo2DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(-89.44, -88.89, -88.33, -87.78, -87.22, -86.67, -86.11, -85.56, -85, -84.44)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg119_To_Neg110_RoundedTo2DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(-83.89, -83.33, -82.78, -82.22, -81.67, -81.11, -80.56, -80, -79.44, -78.89)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg109_To_Neg100_RoundedTo2DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(-78.33, -77.78, -77.22, -76.67, -76.11, -75.56, -75, -74.44, -73.89, -73.33)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg99_To_Neg90_RoundedTo2DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(-72.78, -72.22, -71.67, -71.11, -70.56, -70, -69.44, -68.89, -68.33, -67.78)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-67.22, -66.67, -66.11, -65.56, -65, -64.44, -63.89, -63.33, -62.78, -62.22)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-61.67, -61.11, -60.56, -60, -59.44, -58.89, -58.33, -57.78, -57.22, -56.67)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-56.11, -55.56, -55, -54.44, -53.89, -53.33, -52.78, -52.22, -51.67, -51.11)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-50.56, -50, -49.44, -48.89, -48.33, -47.78, -47.22, -46.67, -46.11, -45.56)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-45, -44.44, -43.89, -43.33, -42.78, -42.22, -41.67, -41.11, -40.56, -40)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-39.44, -38.89, -38.33, -37.78, -37.22, -36.67, -36.11, -35.56, -35, -34.44)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-33.89, -33.33, -32.78, -32.22, -31.67, -31.11, -30.56, -30, -29.44, -28.89)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-28.33, -27.78, -27.22, -26.67, -26.11, -25.56, -25, -24.44, -23.89, -23.33)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg9_To_0_RoundedTo2DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(-22.78, -22.22, -21.67, -21.11, -20.56, -20, -19.44, -18.89, -18.33, -17.78)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _fahrenheitToCelsius = null;
            _temperatureConverter = null;
        }
    }
}
