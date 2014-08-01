using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Kelvin.ToDecimalPlace_2
{
    [TestFixture]
    public class StandardConverter_K_To_F_Should
    {
        private ConversionFormula _kelvinToFahrenheit;

        private ITemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _kelvinToFahrenheit = StandardConverter.KelvinToFahrenheit;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_130_To_140_RoundedTo2DP([Range(130d, 140d, 1d)]double temperature,
                    [Values(-225.67, -223.87, -222.07, -220.27, -218.47, -216.67, -214.87, -213.07, -211.27, -209.47, -207.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_141_To_150_RoundedTo2DP([Range(141d, 150d, 1d)]double temperature,
                    [Values(-205.87, -204.07, -202.27, -200.47, -198.67, -196.87, -195.07, -193.27, -191.47, -189.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_151_To_160_RoundedTo2DP([Range(151d, 160d, 1d)]double temperature,
                    [Values(-187.87, -186.07, -184.27, -182.47, -180.67, -178.87, -177.07, -175.27, -173.47, -171.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_161_To_170_RoundedTo2DP([Range(161d, 170d, 1d)]double temperature,
                    [Values(-169.87, -168.07, -166.27, -164.47, -162.67, -160.87, -159.07, -157.27, -155.47, -153.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_171_To_180_RoundedTo2DP([Range(171d, 180d, 1d)]double temperature,
                    [Values(-151.87, -150.07, -148.27, -146.47, -144.67, -142.87, -141.07, -139.27, -137.47, -135.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_181_To_190_RoundedTo2DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(-133.87, -132.07, -130.27, -128.47, -126.67, -124.87, -123.07, -121.27, -119.47, -117.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_191_To_200_RoundedTo2DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(-115.87, -114.07, -112.27, -110.47, -108.67, -106.87, -105.07, -103.27, -101.47, -99.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_201_To_210_RoundedTo2DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(-97.87, -96.07, -94.27, -92.47, -90.67, -88.87, -87.07, -85.27, -83.47, -81.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_211_To_220_RoundedTo2DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(-79.87, -78.07, -76.27, -74.47, -72.67, -70.87, -69.07, -67.27, -65.47, -63.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_221_To_230_RoundedTo2DP([Range(221d, 230d, 1d)]double temperature,
                    [Values(-61.87, -60.07, -58.27, -56.47, -54.67, -52.87, -51.07, -49.27, -47.47, -45.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_231_To_240_RoundedTo2DP([Range(231d, 240d, 1d)]double temperature,
                    [Values(-43.87, -42.07, -40.27, -38.47, -36.67, -34.87, -33.07, -31.27, -29.47, -27.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_241_To_250_RoundedTo2DP([Range(241d, 250d, 1d)]double temperature,
                    [Values(-25.87, -24.07, -22.27, -20.47, -18.67, -16.87, -15.07, -13.27, -11.47, -9.67)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_251_To_260_RoundedTo2DP([Range(251d, 260d, 1d)]double temperature,
                    [Values(-7.87, -6.07, -4.27, -2.47, -0.67, 1.13, 2.93, 4.73, 6.53, 8.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_261_To_270_RoundedTo2DP([Range(261d, 270d, 1d)]double temperature,
                    [Values(10.13, 11.93, 13.73, 15.53, 17.33, 19.13, 20.93, 22.73, 24.53, 26.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_271_To_280_RoundedTo2DP([Range(271d, 280d, 1d)]double temperature,
                    [Values(28.13, 29.93, 31.73, 33.53, 35.33, 37.13, 38.93, 40.73, 42.53, 44.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_281_To_290_RoundedTo2DP([Range(281d, 290d, 1d)]double temperature,
                    [Values(46.13, 47.93, 49.73, 51.53, 53.33, 55.13, 56.93, 58.73, 60.53, 62.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_291_To_300_RoundedTo2DP([Range(291d, 300d, 1d)]double temperature,
                    [Values(64.13, 65.93, 67.73, 69.53, 71.33, 73.13, 74.93, 76.73, 78.53, 80.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_301_To_310_RoundedTo2DP([Range(301d, 310d, 1d)]double temperature,
                    [Values(82.13, 83.93, 85.73, 87.53, 89.33, 91.13, 92.93, 94.73, 96.53, 98.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_311_To_320_RoundedTo2DP([Range(311d, 320d, 1d)]double temperature,
                    [Values(100.13, 101.93, 103.73, 105.53, 107.33, 109.13, 110.93, 112.73, 114.53, 116.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_321_To_330_RoundedTo2DP([Range(321d, 330d, 1d)]double temperature,
                    [Values(118.13, 119.93, 121.73, 123.53, 125.33, 127.13, 128.93, 130.73, 132.53, 134.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_331_To_340_RoundedTo2DP([Range(331d, 340d, 1d)]double temperature,
                    [Values(136.13, 137.93, 139.73, 141.53, 143.33, 145.13, 146.93, 148.73, 150.53, 152.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_341_To_350_RoundedTo2DP([Range(341d, 350d, 1d)]double temperature,
                    [Values(154.13, 155.93, 157.73, 159.53, 161.33, 163.13, 164.93, 166.73, 168.53, 170.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_351_To_360_RoundedTo2DP([Range(351d, 360d, 1d)]double temperature,
                    [Values(172.13, 173.93, 175.73, 177.53, 179.33, 181.13, 182.93, 184.73, 186.53, 188.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_361_To_370_RoundedTo2DP([Range(361d, 370d, 1d)]double temperature,
                    [Values(190.13, 191.93, 193.73, 195.53, 197.33, 199.13, 200.93, 202.73, 204.53, 206.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertKelvinToFahrenheitRange_371_To_380_RoundedTo2DP([Range(371d, 380d, 1d)]double temperature,
                    [Values(208.13, 209.93, 211.73, 213.53, 215.33, 217.13, 218.93, 220.73, 222.53, 224.33)]double expected)
        {
            double actual = _sut.Convert(temperature, _kelvinToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _kelvinToFahrenheit = null;
            _sut = null;
        }
    }
}
