using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Kelvin.ToDecimalPlace_2
{
    [TestFixture]
    public class StandardConverter_K_To_C_Should
    {
        private ConversionFormula _kelvinToCelsius;

        private ITemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _kelvinToCelsius = StandardConverter.KelvinToCelsius;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_130_To_140_RoundedTo2DP([Range(130d, 140d, 1d)]double temperature,
                    [Values(-143.15, -142.15, -141.15, -140.15, -139.15, -138.15, -137.15, -136.15, -135.15, -134.15, -133.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_141_To_150_RoundedTo2DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(-132.15, -131.15, -130.15, -129.15, -128.15, -127.15, -126.15, -125.15, -124.15, -123.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_151_To_160_RoundedTo2DP([Range(151d, 160d, 1d)]double temperature,
                    [Values(-122.15, -121.15, -120.15, -119.15, -118.15, -117.15, -116.15, -115.15, -114.15, -113.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_161_To_170_RoundedTo2DP([Range(161d, 170d, 1d)]double temperature,
                    [Values(-112.15, -111.15, -110.15, -109.15, -108.15, -107.15, -106.15, -105.15, -104.15, -103.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_171_To_180_RoundedTo2DP([Range(171d, 180d, 1d)]double temperature,
                    [Values(-102.15, -101.15, -100.15, -99.15, -98.15, -97.15, -96.15, -95.15, -94.15, -93.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_181_To_190_RoundedTo2DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(-92.15, -91.15, -90.15, -89.15, -88.15, -87.15, -86.15, -85.15, -84.15, -83.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_191_To_200_RoundedTo2DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(-82.15, -81.15, -80.15, -79.15, -78.15, -77.15, -76.15, -75.15, -74.15, -73.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_201_To_210_RoundedTo2DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(-72.15, -71.15, -70.15, -69.15, -68.15, -67.15, -66.15, -65.15, -64.15, -63.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_211_To_220_RoundedTo2DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(-62.15, -61.15, -60.15, -59.15, -58.15, -57.15, -56.15, -55.15, -54.15, -53.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_221_To_230_RoundedTo2DP([Range(221d, 230d, 1d)]double temperature,
                    [Values(-52.15, -51.15, -50.15, -49.15, -48.15, -47.15, -46.15, -45.15, -44.15, -43.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_231_To_240_RoundedTo2DP([Range(231d, 240d, 1d)]double temperature,
                    [Values(-42.15, -41.15, -40.15, -39.15, -38.15, -37.15, -36.15, -35.15, -34.15, -33.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_241_To_250_RoundedTo2DP([Range(241d, 250d, 1d)]double temperature,
                    [Values(-32.15, -31.15, -30.15, -29.15, -28.15, -27.15, -26.15, -25.15, -24.15, -23.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_251_To_260_RoundedTo2DP([Range(251d, 260d, 1d)]double temperature,
                    [Values(-22.15, -21.15, -20.15, -19.15, -18.15, -17.15, -16.5, -15.15, -14.15, -13.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_261_To_270_RoundedTo2DP([Range(261d, 270d, 1d)]double temperature,
                    [Values(-12.15, -11.15, -10.15, -9.15, -8.15, -7.15, -6.15, -5.15, -4.15, -3.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_271_To_280_RoundedTo2DP([Range(271d, 280d, 1d)]double temperature,
                    [Values(-2.15, -1.15, 0.15, 1.15, 2.15, 3.15, 4.15, 5.15, 6.15, 7.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_281_To_290_RoundedTo2DP([Range(281d, 290d, 1d)]double temperature,
                    [Values(8.15, 9.15, 10.15, 11.15, 12.15, 13.15, 14.15, 15.15, 16.15, 17.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_291_To_300_RoundedTo2DP([Range(291d, 300d, 1d)]double temperature,
                    [Values(18.15, 19.15, 20.15, 21.15, 22.15, 23.15, 24.15, 25.15, 26.15, 27.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_301_To_310_RoundedTo2DP([Range(301d, 310d, 1d)]double temperature,
                    [Values(28.15, 29.15, 30.15, 31.15, 32.15, 33.15, 34.15, 35.15, 36.15, 37.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_311_To_320_RoundedTo2DP([Range(311d, 320d, 1d)]double temperature,
                    [Values(38.15, 39.15, 40.15, 41.15, 42.15, 43.15, 44.15, 45.15, 46.15, 47.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_321_To_330_RoundedTo2DP([Range(321d, 330d, 1d)]double temperature,
                    [Values(48.15, 49.15, 50.15, 51.15, 52.15, 53.15, 54.15, 55.15, 56.15, 57.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_331_To_340_RoundedTo2DP([Range(331d, 340d, 1d)]double temperature,
                    [Values(58.15, 59.15, 60.15, 61.15, 62.15, 63.15, 64.15, 65.15, 66.15, 67.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_341_To_350_RoundedTo2DP([Range(341d, 350d, 1d)]double temperature,
                    [Values(68.15, 69.15, 70.15, 71.15, 72.15, 73.15, 74.15, 75.15, 76.15, 77.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_351_To_360_RoundedTo2DP([Range(351d, 360d, 1d)]double temperature,
                    [Values(78.15, 79.15, 80.15, 81.15, 82.15, 83.15, 84.15, 85.15, 86.15, 87.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_361_To_370_RoundedTo2DP([Range(361d, 370d, 1d)]double temperature,
                    [Values(88.15, 89.15, 90.15, 91.15, 92.15, 93.15, 94.15, 95.15, 96.15, 97.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_371_To_380_RoundedTo2DP([Range(371d, 380d, 1d)]double temperature,
                    [Values(98.15, 99.15, 100.15, 101.15, 102.15, 103.15, 104.15, 105.15, 106.15, 107.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _kelvinToCelsius = null;
            _sut = null;
        }
    }
}
