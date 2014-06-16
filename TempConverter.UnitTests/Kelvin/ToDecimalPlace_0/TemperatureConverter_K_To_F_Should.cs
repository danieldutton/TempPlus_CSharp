using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Kelvin.ToDecimalPlace_0
{
    [TestFixture]
    public class TemperatureConverter_K_To_F_Should
    {
        private ConversionFormula _kelvinToFahrenheit;

        private ITemperatureConverter _temperatureConverter;

        private const int RoundBy = 0;

        [SetUp]
        public void Init()
        {
            _kelvinToFahrenheit = TemperatureConverter.KelvinToFahrenheit;
            _temperatureConverter = new TemperatureConverter();
        }

        #region Kelvin To Fahrenheit Positive Values

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_170_To_180_RoundedTo0DP([Range(170d, 180d, 1d)]double temperature,
                    [Values(-154, -152, -150, -148, -146, -145, -143, -141, -139, -137, -136)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_181_To_190_RoundedTo0DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(-134, -132, -130, -128, -127, -125, -123, -121, -119, -118)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_191_To_200_RoundedTo0DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(-116, -114, -112, -110, -109, -107, -105, -103, -101, -100)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_201_To_210_RoundedTo0DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(-98, -96, -94, -92, -91, -89, -87, -85, -83, -82)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_211_To_220_RoundedTo0DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(-80, -78, -76, -74, -73, -71, -69, -67, -65, -64)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_221_To_230_RoundedTo0DP([Range(221d, 230d, 1d)]double temperature,
                    [Values(-62, -60, -58, -56, -55, -53, -51, -49, -47, -46)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_231_To_240_RoundedTo0DP([Range(231d, 240d, 1d)]double temperature,
                    [Values(-44, -42, -40, -38, -37, -35, -33, -31, -29, -28)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_241_To_250_RoundedTo0DP([Range(241d, 250d, 1d)]double temperature,
                    [Values(-26, -24, -22, -20, -19, -17, -15, -13, -11, -10)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_251_To_260_RoundedTo0DP([Range(251d, 260d, 1d)]double temperature,
                    [Values(-8, -6, -4, -2, -1, 1, 3, 5, 7, 8)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_261_To_270_RoundedTo0DP([Range(261d, 270d, 1d)]double temperature,
                    [Values(10, 12, 14, 16, 17, 19, 21, 23, 25, 26)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_271_To_280_RoundedTo0DP([Range(271d, 280d, 1d)]double temperature,
                    [Values(28, 30, 32, 34, 35, 37, 39, 41, 43, 44)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_281_To_290_RoundedTo0DP([Range(281d, 290d, 1d)]double temperature,
                    [Values(46, 48, 50, 52, 53, 55, 57, 59, 61, 62)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_291_To_300_RoundedTo0DP([Range(291d, 300d, 1d)]double temperature,
                    [Values(64, 66, 68, 70, 71, 73, 75, 77, 79, 80)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_301_To_310_RoundedTo0DP([Range(301d, 310d, 1d)]double temperature,
                    [Values(82, 84, 86, 88, 89, 91, 93, 95, 97, 98)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_311_To_320_RoundedTo0DP([Range(311d, 320d, 1d)]double temperature,
                    [Values(100, 102, 104, 106, 107, 109, 111, 113, 115, 116)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_321_To_330_RoundedTo0DP([Range(321d, 330d, 1d)]double temperature,
                    [Values(118, 120, 122, 124, 125, 127, 129, 131, 133, 134)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_331_To_340_RoundedTo0DP([Range(331d, 340d, 1d)]double temperature,
                    [Values(136, 138, 140, 142, 143, 145, 147, 149, 151, 152)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _kelvinToFahrenheit = null;
            _temperatureConverter = null;
        }
    }
}
