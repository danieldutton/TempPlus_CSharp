using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Celsius.ToDecimalPlace_2
{
    [TestFixture]
    public class StandardConverter_C_To_F_Should
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

        #region Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_0_To_10_RoundedTo2DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(32.00, 33.80, 35.60, 37.40, 39.20, 41.00, 42.80, 44.60, 46.40, 48.20, 50.00)]double expected)
        {          
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_11_To_20_RoundedTo2DP([Range(11d, 20d, 1d)]double temperature,
                    [Values(51.80, 53.60, 55.40, 57.20, 59.00, 60.80, 62.60, 64.40, 66.20, 68.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_21_To_30_RoundedTo2DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(69.80, 71.60, 73.40, 75.20, 77.00, 78.80, 80.60, 82.40, 84.20, 86.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_31_To_40_RoundedTo2DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(87.80, 89.60, 91.40, 93.20, 95.00, 96.80, 98.60, 100.40, 102.20, 104.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_41_To_50_RoundedTo2DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(105.80, 107.60, 109.40, 111.20, 113.00, 114.80, 116.60, 118.40, 120.20, 122.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_51_To_60_RoundedTo2DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(123.80, 125.60, 127.40, 129.20, 131.00, 132.80, 134.60, 136.40, 138.20, 140.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_61_To_70_RoundedTo2DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(141.80, 143.60, 145.40, 147.20, 149.00, 150.80, 152.60, 154.40, 156.20, 158.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_71_To_80_RoundedTo2DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(159.80, 161.60, 163.40, 165.20, 167.00, 168.80, 170.60, 172.40, 174.20, 176.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_81_To_90_RoundedTo2DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(177.80, 179.60, 181.40, 183.20, 185.00, 186.80, 188.60, 190.40, 192.20, 194.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_91_To_100_RoundedTo2DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(195.80, 197.60, 199.40, 201.20, 203.00, 204.80, 206.60, 208.40, 210.20, 212.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_101_To_110_RoundedTo2DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(213.80, 215.60, 217.40, 219.20, 221.00, 222.80, 224.60, 226.40, 228.20, 230.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }
        
        #endregion

        #region Negative Values

        
        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg140_To_Neg130_RoundedTo2DP([Range(-140d, -130d, 1d)]double temperature,
                    [Values(-220.00, -218.20, -216.40, -214.60, -212.80, -211.00, -209.20, -207.40, -205.60, -203.80, -202.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }
        
        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg129_To_Neg120_RoundedTo2DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(-200.20, -198.40, -196.60, -194.80, -193.00, -191.20, -189.40, -187.60, -185.80, -184.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }
        
        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg119_To_Neg110_RoundedTo2DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(-182.20, -180.40, -178.60, -176.80, -175.00, -173.20, -171.40, -169.60, -167.80, -166.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg109_To_Neg100_RoundedTo2DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(-164.20, -162.40, -160.60, -158.80, -157.00, -155.20, -153.40, -151.60, -149.80, -148.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg99_To_Neg90_RoundedTo2DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(-146.20, -144.40, -142.60, -140.80, -139, -137.20, -135.40, -133.60, -131.80, -130.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-128.20, -126.40, -124.60, -122.80, -121.00, -119.20, -117.40, -115.60, -113.80, -112.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-110.20, -108.40, -106.60, -104.80, -103.00, -101.20, -99.40, -97.60, -95.80, -94.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-92.20, -90.40, -88.60, -86.80, -85.00, -83.20, -81.40, -79.60, -77.80, -76.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-74.20, -72.40, -70.60, -68.80, -67.00, -65.20, -63.40, -61.60, -59.80, -58.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-56.20, -54.40, -52.60,-50.80, -49.00, -47.20, -45.40, -43.60, -41.80, -40.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-38.20, -36.40, -34.60, -32.80, -31.00, -29.20, -27.40, -25.60, -23.80, -22.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-20.20, -18.40, -16.60, -14.80, -13.00, -11.20, -9.40, -7.60, -5.80, -4.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-2.20, -0.40, 1.40, 3.20, 5.00, 6.80, 8.60, 10.40,12.20, 14.00)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg9_To_0_RoundedTo2DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(15.80, 17.60, 19.40, 21.20, 23.00, 24.80, 26.60, 28.40, 30.20, 32.00)]double expected)
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
