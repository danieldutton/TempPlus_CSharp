using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Kelvin.ToDecimalPlace_0
{
    [TestFixture]
    public class StandardConverter_K_To_C_Should
    {
        private ConversionFormula _kelvinToCelsius;

        private ITemperatureConverter _sut;

        private const int RoundBy = 0;

        [SetUp]
        public void Init()
        {
            _kelvinToCelsius = StandardConverter.KelvinToCelsius;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_130_To_140_RoundedTo2DP([Range(130d, 140d, 1d)]double temperature,
                    [Values(-143, -142, -141, -140, -139, -138, -137, -136, -135, -134, -133)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_141_To_150_RoundedTo2DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(-132, -131, -130, -129, -128, -127, -126, -125, -124, -123)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_151_To_160_RoundedTo2DP([Range(151d, 160d, 1d)]double temperature,
                    [Values(-122, -121, -120, -119, -118, -117, -116, -115, -114, -113)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_161_To_170_RoundedTo2DP([Range(161d, 170d, 1d)]double temperature,
                    [Values(-112, -111, -110, -109, -108, -107, -106, -105, -104, -103)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_171_To_180_RoundedTo2DP([Range(171d, 180d, 1d)]double temperature,
                    [Values(-102, -101, -100, -99, -98, -97, -96, -95, -94, -93)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_181_To_190_RoundedTo2DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(-92, -91, -90, -89, -88, -87, -86, -85, -84, -83)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_191_To_200_RoundedTo2DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(-82, -81, -80, -79, -78, -77, -76, -75, -74, -73)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_201_To_210_RoundedTo2DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(-72, -71, -70, -69, -68, -67, -66, -65, -64, -63)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_211_To_220_RoundedTo2DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(-62, -61, -60, -59, -58, -57, -56, -55, -54, -53)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_221_To_230_RoundedTo2DP([Range(221d, 230d, 1d)]double temperature,
                    [Values(-52, -51, -50, -49, -48, -47, -46, -45, -44, -43)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_231_To_240_RoundedTo2DP([Range(231d, 240d, 1d)]double temperature,
                    [Values(-42, -41, -40, -39, -38, -37, -36, -35, -34, -33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_241_To_250_RoundedTo2DP([Range(241d, 250d, 1d)]double temperature,
                    [Values(-32, -31, -30, -29, -28, -27, -26, -25, -24, -23)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_251_To_260_RoundedTo2DP([Range(251d, 260d, 1d)]double temperature,
                    [Values(-22, -21, -20, -19, -18, -17, -16, -15, -14, -13)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_261_To_270_RoundedTo2DP([Range(261d, 270d, 1d)]double temperature,
                    [Values(-12, -11, -10, -9, -8, -7, -6, -5, -4, -3)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_271_To_280_RoundedTo2DP([Range(271d, 280d, 1d)]double temperature,
                    [Values(-2, -1, 0, 1, 2, 3, 4, 5, 6, 7)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_281_To_290_RoundedTo2DP([Range(281d, 290d, 1d)]double temperature,
                    [Values(8, 9, 10, 11, 12, 13, 14, 15, 16, 17)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_291_To_300_RoundedTo2DP([Range(291d, 300d, 1d)]double temperature,
                    [Values(18, 19, 20, 21, 22, 23, 24, 25, 26, 27)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_301_To_310_RoundedTo2DP([Range(301d, 310d, 1d)]double temperature,
                    [Values(28, 29, 30, 31, 32, 33, 34, 35, 36, 37)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_311_To_320_RoundedTo2DP([Range(311d, 320d, 1d)]double temperature,
                    [Values(38, 39, 40, 41, 42, 43, 44, 45, 46, 47)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_321_To_330_RoundedTo2DP([Range(321d, 330d, 1d)]double temperature,
                    [Values(48, 49, 50, 51, 52, 53, 54, 55, 56, 57)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_331_To_340_RoundedTo2DP([Range(331d, 340d, 1d)]double temperature,
                    [Values(58, 59, 60, 61, 62, 63, 64, 65, 66, 67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_341_To_350_RoundedTo2DP([Range(341d, 350d, 1d)]double temperature,
                    [Values(68, 69, 70, 71, 72, 73, 74, 75, 76, 77)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_351_To_360_RoundedTo2DP([Range(351d, 360d, 1d)]double temperature,
                    [Values(78, 79, 80, 81, 82, 83, 84, 85, 86, 87)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_361_To_370_RoundedTo2DP([Range(361d, 370d, 1d)]double temperature,
                    [Values(88, 89, 90, 91, 92, 93, 94, 95, 96, 97)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertKelvinToCelsiusRange_371_To_380_RoundedTo2DP([Range(371d, 380d, 1d)]double temperature,
                    [Values(98, 99, 100, 101, 102, 103, 104, 105, 106, 107)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToCelsius, RoundBy);

            Assert.AreEqual(expected, actual);
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
