using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Fahrenheit.ToDecimalPlace_2
{
    [TestFixture]
    public class StandardConverter_F_To_C_Should
    {
        private ConversionFormula _fahrenheitToCelsius;

        private ITemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _fahrenheitToCelsius = StandardConverter.FahrenheitToCelsius;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_0_To_10_RoundedTo2DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(-17.78, -17.22, -16.67, -16.11, -15.56, -15, -14.44, -13.89, -13.33, -12.78, -12.22)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_11_To_20_RoundedTo2DP([Range(11.0d, 20d, 1d)]double temperature,
                    [Values(-11.67, -11.11, -10.56, -10, -9.44, -8.89, -8.33, -7.78, -7.22, -6.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_21_To_30_RoundedTo2DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(-6.11, -5.56, -5, -4.44, -3.89, -3.33, -2.78, -2.22, -1.67, -1.11)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_31_To_40_RoundedTo2DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(-0.56, 0, 0.56, 1.11, 1.67, 2.22, 2.78, 3.33, 3.89, 4.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_41_To_50_RoundedTo2DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(5, 5.56, 6.11, 6.67, 7.22, 7.78, 8.33, 8.89, 9.44, 10)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_51_To_60_RoundedTo2DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(10.56, 11.11, 11.67, 12.22, 12.78, 13.33, 13.89, 14.44, 15, 15.56)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_61_To_70_RoundedTo2DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(16.11, 16.67, 17.22, 17.78, 18.33, 18.89, 19.44, 20, 20.56, 21.11)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_71_To_80_RoundedTo2DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(21.67, 22.22, 22.78, 23.33, 23.89, 24.44, 25, 25.56, 26.11, 26.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_81_To_90_RoundedTo2DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(27.22, 27.78, 28.33, 28.89, 29.44, 30, 30.56, 31.11, 31.67, 32.22)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_91_To_100_RoundedTo2DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(32.78, 33.33, 33.89, 34.44, 35, 35.56, 36.11, 36.67, 37.22, 37.78)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_101_To_110_RoundedTo2DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(38.33, 38.89, 39.44, 40, 40.56, 41.11, 41.67, 42.22, 42.78, 43.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_111_To_120_RoundedTo2DP([Range(111d, 120d, 1d)]double temperature,
                    [Values(43.89, 44.44, 45, 45.56, 46.11, 46.67, 47.22, 47.78, 48.33, 48.89)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_121_To_130_RoundedTo2DP([Range(121d, 130d, 1d)]double temperature,
                    [Values(49.44, 50, 50.56, 51.11, 51.67, 52.22, 52.78, 53.33, 53.89, 54.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_131_To_140_RoundedTo2DP([Range(131d, 140d, 1d)]double temperature,
                    [Values(55, 55.56, 56.11, 56.67, 57.22, 57.78, 58.33, 58.89, 59.44, 60)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_141_To_150_RoundedTo2DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(60.56, 61.11, 61.67, 62.22, 62.78, 63.33, 63.89, 64.44, 65, 65.56)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_151_To_160_RoundedTo2DP([Range(151d, 160d, 1d)]double temperature,
                    [Values(66.11, 66.67, 67.22, 67.78, 68.33, 68.89, 69.44, 70, 70.56, 71.11)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_161_To_170_RoundedTo2DP([Range(161d, 170d, 1d)]double temperature,
                    [Values(71.67, 72.22, 72.78, 73.33, 73.89, 74.44, 75, 75.56, 76.11, 76.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_171_To_180_RoundedTo2DP([Range(171d, 180d, 1d)]double temperature,
                    [Values(77.22, 77.78, 78.33, 78.89, 79.44, 80, 80.56, 81.11, 81.67, 82.22)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_181_To_190_RoundedTo2DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(82.78, 83.33, 83.89, 84.44, 85, 85.56, 86.11, 86.67, 87.22, 87.78)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_191_To_200_RoundedTo2DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(88.33, 88.89, 89.44, 90, 90.56, 91.11, 91.67, 92.22, 92.78, 93.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_201_To_210_RoundedTo2DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(93.89, 94.44, 95, 95.56, 96.11, 96.67, 97.22, 97.78, 98.33, 98.89)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_211_To_220_RoundedTo2DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(99.44, 100, 100.56, 101.11, 101.67, 102.22, 102.78, 103.33, 103.89, 104.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Negative Values

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg220_To_Neg210_RoundedTo2DP([Range(-220d, -210d, 1d)]double temperature,
                    [Values(-140, -139.44, -138.89, -138.33, -137.78, -137.22, -136.67, -136.11, -135.56, -135, -134.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg209_To_Neg200_RoundedTo2DP([Range(-209d, -200d, 1d)]double temperature,
                    [Values(-133.89, -133.33, -132.78, -132.22, -131.67, -131.11, -130.56, -130, -129.44, -128.89)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg199_To_Neg190_RoundedTo2DP([Range(-199d, -190d, 1d)]double temperature,
                    [Values(-128.33, -127.78, -127.22, -126.67, -126.11, -125.56, -125, -124.44, -123.89, -123.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg189_To_Neg180_RoundedTo2DP([Range(-189d, -180d, 1d)]double temperature,
                    [Values(-122.78, -122.22, -121.67, -121.11, -120.56, -120, -119.44, -118.89, -118.33, -117.78)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg179_To_Neg170_RoundedTo2DP([Range(-179d, -170d, 1d)]double temperature,
                    [Values(-117.22, -116.67, -116.11, -115.56, -115, -114.44, -113.89, -113.33, -112.78, -112.22)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg169_To_Neg160_RoundedTo2DP([Range(-169d, -160d, 1d)]double temperature,
                    [Values(-111.67, -111.11, -110.56, -110, -109.44, -108.89, -108.33, -107.78, -107.22, -106.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg159_To_Neg150_RoundedTo2DP([Range(-159d, -150d, 1d)]double temperature,
                    [Values(-106.11, -105.56, -105, -104.44, -103.89, -103.33, -102.78, -102.22, -101.67, -101.11)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg150_To_Neg140_RoundedTo2DP([Range(-150d, -140d, 1d)]double temperature,
                    [Values(-101.11, -100.56, -100, -99.44, -98.89, -98.33, -97.78, -97.22, -96.67, -96.11, -95.56)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg139_To_Neg130_RoundedTo2DP([Range(-139d, -130d, 1d)]double temperature,
                    [Values(-95, -94.44, -93.89, -93.33, -92.78, -92.22, -91.67, -91.11, -90.56, -90)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg129_To_Neg120_RoundedTo2DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(-89.44, -88.89, -88.33, -87.78, -87.22, -86.67, -86.11, -85.56, -85, -84.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg119_To_Neg110_RoundedTo2DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(-83.89, -83.33, -82.78, -82.22, -81.67, -81.11, -80.56, -80, -79.44, -78.89)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg109_To_Neg100_RoundedTo2DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(-78.33, -77.78, -77.22, -76.67, -76.11, -75.56, -75, -74.44, -73.89, -73.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg99_To_Neg90_RoundedTo2DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(-72.78, -72.22, -71.67, -71.11, -70.56, -70, -69.44, -68.89, -68.33, -67.78)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-67.22, -66.67, -66.11, -65.56, -65, -64.44, -63.89, -63.33, -62.78, -62.22)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-61.67, -61.11, -60.56, -60, -59.44, -58.89, -58.33, -57.78, -57.22, -56.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-56.11, -55.56, -55, -54.44, -53.89, -53.33, -52.78, -52.22, -51.67, -51.11)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-50.56, -50, -49.44, -48.89, -48.33, -47.78, -47.22, -46.67, -46.11, -45.56)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-45, -44.44, -43.89, -43.33, -42.78, -42.22, -41.67, -41.11, -40.56, -40)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-39.44, -38.89, -38.33, -37.78, -37.22, -36.67, -36.11, -35.56, -35, -34.44)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-33.89, -33.33, -32.78, -32.22, -31.67, -31.11, -30.56, -30, -29.44, -28.89)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-28.33, -27.78, -27.22, -26.67, -26.11, -25.56, -25, -24.44, -23.89, -23.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToCelsiusRange_Neg9_To_0_RoundedTo2DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(-22.78, -22.22, -21.67, -21.11, -20.56, -20, -19.44, -18.89, -18.33, -17.78)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
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
