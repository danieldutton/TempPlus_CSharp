using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Celsius.ToDecimalPlace_2
{
    [TestFixture]
    public class TemperatureConverter_C_To_F_Should
    {
        private ConversionFormula _celsiusToFahrenheit;

        private ITemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _celsiusToFahrenheit = StandardConverter.CelsiusToFahrenheit;
            _sut = new StandardConverter();
        }

        #region Celsius To Fahrenheit Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_0_To_10_RoundedTo2DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(32, 33.8, 35.6, 37.4, 39.2, 41, 42.8, 44.6, 46.4, 48.2, 50)]double expected)
        {          
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_11_To_20_RoundedTo2DP([Range(11d, 20d, 1d)]double temperature,
                    [Values(51.8, 53.6, 55.4, 57.2, 59, 60.8, 62.6, 64.4, 66.2, 68)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_21_To_30_RoundedTo2DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(69.8, 71.6, 73.4, 75.2, 77, 78.8, 80.6, 82.4, 84.2, 86)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_31_To_40_RoundedTo2DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(87.8, 89.6, 91.4, 93.2, 95, 96.8, 98.6, 100.4, 102.2, 104)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_41_To_50_RoundedTo2DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(105.8, 107.6, 109.4, 111.2, 113, 114.8, 116.6, 118.4, 120.2, 122)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_51_To_60_RoundedTo2DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(123.80, 125.6, 127.4, 129.2, 131, 132.8, 134.6, 136.4, 138.2, 140)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_61_To_70_RoundedTo2DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(141.8, 143.6, 145.4, 147.2, 149, 150.8, 152.6, 154.4, 156.2, 158)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }
        
        #endregion

        #region Celsius To Fahrenheit Negative Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg100_To_Neg90_RoundedTo2DP([Range(-100d, -90d, 1d)]double temperature,
                    [Values(-148, -146.2, -144.4, -142.6, -140.8, -139, -137.2, -135.4, -133.6, -131.8, -130)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-128.2, -126.4, -124.6, -122.8, -121, -119.2, -117.4, -115.6, -113.8, -112)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-110.2, -108.4, -106.6, -104.8, -103, -101.2, -99.4, -97.6, -95.8, -94)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-92.2, -90.4, -88.6, -86.8, -85, -83.2, -81.4, -79.6, -77.8, -76)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-74.2, -72.4, -70.6, -68.8, -67, -65.2, -63.4, -61.6, -59.8, -58)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-56.2, -54.4, -52.6,-50.8, -49, -47.2, -45.4, -43.6, -41.8, -40)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-38.2, -36.4, -34.6, -32.8, -31, -29.2, -27.4, -25.6, -23.8, -22)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-20.2, -18.4, -16.6, -14.8, -13, -11.2, -9.4, -7.6, -5.8, -4)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-2.2, -0.4, 1.4, 3.2, 5, 6.8, 8.6, 10.4,12.2, 14)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg9_To_0_RoundedTo2DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(15.8, 17.6, 19.4, 21.2, 23, 24.8, 26.6, 28.4, 30.2, 32)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _celsiusToFahrenheit = null;
            _sut = null;
        }
    }
}
