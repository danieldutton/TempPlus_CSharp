using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Fahrenheit.ToDecimalPlace_0
{
    [TestFixture]
    public class StandardConverter_F_To_C_Should
    {
        private ConversionFormula _fahrenheitToCelsius;

        private ITemperatureConverter _sut;

        private const int RoundBy = 0;

        [SetUp]
        public void Init()
        {
            _fahrenheitToCelsius = StandardConverter.FahrenheitToCelsius;
            _sut = new StandardConverter();
        }

        #region Fahrenheit To Celsius Positive Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_0_To_10_RoundedTo0DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(-18, -17, -17, -16, -16, -15, -14, -14, -13, -13, -12)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_11_To_20_RoundedTo0DP([Range(11.0d, 20d, 1d)]double temperature,
                    [Values(-12, -11, -11, -10, -9, -9, -8, -8, -7, -7)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_21_To_30_RoundedTo0DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(-6, -6, -5, -4, -4, -3, -3, -2, -2, -1)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_31_To_40_RoundedTo0DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(-1, 0, 1, 1, 2, 2, 3, 3, 4, 4)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_41_To_50_RoundedTo0DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(5, 6, 6, 7, 7, 8, 8, 9, 9, 10)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_51_To_60_RoundedTo0DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(11, 11, 12, 12, 13, 13, 14, 14, 15, 16)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_61_To_70_RoundedTo0DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(16, 17, 17, 18, 18, 19, 19, 20, 21, 21)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_71_To_80_RoundedTo0DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(22, 22, 23, 23, 24, 24, 25, 26, 26, 27)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_81_To_90_RoundedTo0DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(27, 28, 28, 29, 29, 30, 31, 31, 32, 32)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_91_To_100_RoundedTo0DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(33, 33, 34, 34, 35, 36, 36, 37, 37, 38)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_101_To_110_RoundedTo0DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(38, 39, 39, 40, 41, 41, 42, 42, 43, 43)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_111_To_120_RoundedTo0DP([Range(111d, 120d, 1d)]double temperature,
                    [Values(44, 44, 45, 46, 46, 47, 47, 48, 48, 49)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_121_To_130_RoundedTo0DP([Range(121d, 130d, 1d)]double temperature,
                    [Values(49, 50, 51, 51, 52, 52, 53, 53, 54, 54)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_131_To_140_RoundedTo0DP([Range(131d, 140d, 1d)]double temperature,
                    [Values(55, 56, 56, 57, 57, 58, 58, 59, 59, 60)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_141_To_150_RoundedTo0DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(61, 61, 62, 62, 63, 63, 64, 64, 65, 66)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Fahrenheit To Celsius Negative Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg150_To_Neg140_RoundedTo0DP([Range(-150d, -140d, 1d)]double temperature,
                    [Values(-101, -101, -100, -99, -99, -98, -98, -97, -97, -96, -96)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg139_To_Neg130_RoundedTo0DP([Range(-139d, -130d, 1d)]double temperature,
                    [Values(-95, -94, -94, -93, -93, -92, -92, -91, -91, -90)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg129_To_Neg120_RoundedTo0DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(-89, -89, -88, -88, -87, -87, -86, -86, -85, -84)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg119_To_Neg110_RoundedTo0DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(-84, -83, -83, -82, -82, -81, -81, -80, -79, -79)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg109_To_Neg100_RoundedTo0DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(-78, -78, -77, -77, -76, -76, -75, -74, -74, -73)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg99_To_Neg90_RoundedTo0DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(-73, -72, -72, -71, -71, -70, -69, -69, -68, -68)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg89_To_Neg80_RoundedTo0DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-67, -67, -66, -66, -65, -64, -64, -63, -63, -62)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg79_To_Neg70_RoundedTo0DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-62, -61, -61, -60, -59, -59, -58, -58, -57, -57)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg69_To_Neg60_RoundedTo0DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-56, -56, -55, -54, -54, -53, -53, -52, -52, -51)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg59_To_Neg50_RoundedTo0DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-51, -50, -49, -49, -48, -48, -47, -47, -46, -46)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg49_To_Neg40_RoundedTo0DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-45, -44, -44, -43, -43, -42, -42, -41, -41, -40)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg39_To_Neg30_RoundedTo0DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-39, -39, -38, -38, -37, -37, -36, -36, -35, -34)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg29_To_Neg20_RoundedTo0DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-34, -33, -33, -32, -32, -31, -31, -30, -29, -29)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg19_To_Neg10_RoundedTo0DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-28, -28, -27, -27, -26, -26, -25, -24, -24, -23)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg9_To_0_RoundedTo0DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(-23, -22, -22, -21, -21, -20, -19, -19, -18, -18)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _fahrenheitToCelsius = null;
            _sut = null;
        }
    }
}
