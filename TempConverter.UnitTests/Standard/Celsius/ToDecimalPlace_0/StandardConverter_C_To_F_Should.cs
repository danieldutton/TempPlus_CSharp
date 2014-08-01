using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Celsius.ToDecimalPlace_0
{
    [TestFixture]
    public class StandardConverter_C_To_F_Should
    {
        private ConversionFormula _celsiusToFahrenheit;

        private ITemperatureConverter _sut;

        private const int RoundBy = 0;


        [SetUp]
        public void Init()
        {
            _celsiusToFahrenheit = StandardConverter.CelsiusToFahrenheit;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_0_To_10_RoundedTo0DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(32, 34, 36, 37, 39, 41, 43, 45, 46, 48, 50)]double expected)
        {          
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_11_To_20_RoundedTo0DP([Range(11d, 20d, 1d)]double temperature,
                    [Values(52, 54, 55, 57, 59, 61, 63, 64, 66, 68)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_21_To_30_RoundedTo0DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(70, 72, 73, 75, 77, 79, 81, 82, 84, 86)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_31_To_40_RoundedTo0DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(88, 90, 91, 93, 95, 97, 99, 100, 102, 104)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_41_To_50_RoundedTo0DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(106, 108, 109, 111, 113, 115, 117, 118, 120, 122)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_51_To_60_RoundedTo0DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(124, 126, 127, 129, 131, 133, 135, 136, 138, 140)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_61_To_70_RoundedTo0DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(142, 144, 145, 147, 149, 151, 153, 154, 156, 158)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_71_To_80_RoundedTo0DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(160, 162, 163, 165, 167, 169, 171, 172, 174, 176)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_81_To_90_RoundedTo0DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(178, 180, 181, 183, 185, 187, 189, 190, 192, 194)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_91_To_100_RoundedTo0DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(196, 198, 199, 201, 203, 205, 207, 208, 210, 212)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_101_To_110_RoundedTo0DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(214, 216, 217, 219, 221, 223, 225, 226, 228, 230)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        
        #endregion

        #region Negative Values

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg140_To_Neg130_RoundedTo2DP([Range(-140d, -130d, 1d)]double temperature,
                    [Values(-220, -218, -216, -215, -213, -211, -209, -207, -206, -204, -202)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg129_To_Neg120_RoundedTo2DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(-200, -198, -197, -195, -193, -191, -189, -188, -186, -184)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg119_To_Neg110_RoundedTo2DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(-182, -180, -179, -177, -175, -173, -171, -170, -168, -166)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg109_To_Neg100_RoundedTo2DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(-164, -162, -161, -159, -157, -155, -153, -152, -150, -148)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        //
        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg99_To_Neg90_RoundedTo0DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(-146, -144, -143, -141, -139, -137, -135, -134, -132, -130)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg89_To_Neg80_RoundedTo0DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(-128, -126, -125, -123, -121, -119, -117, -116, -114, -112)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg79_To_Neg70_RoundedTo0DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(-110, -108, -107, -105, -103, -101, -99, -98, -96, -94)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg69_To_Neg60_RoundedTo0DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(-92, -90, -89, -87, -85, -83, -81, -80, -78, -76)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg59_To_Neg50_RoundedTo0DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(-74, -72, -71, -69, -67, -65, -63, -62, -60, -58)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg49_To_Neg40_RoundedTo0DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(-56, -54, -53,-51, -49, -47, -45, -44, -42, -40)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg39_To_Neg30_RoundedTo0DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(-38, -36, -35, -33, -31, -29, -27, -26, -24, -22)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg29_To_Neg20_RoundedTo0DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(-20, -18, -17, -15, -13, -11, -9, -8, -6, -4)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg19_To_Neg10_RoundedTo0DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(-2, -0, 1, 3, 5, 7, 9, 10,12, 14)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToFahrenheitRange_Neg9_To_0_RoundedTo0DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(16, 18, 19, 21, 23, 25, 27, 28, 30, 32)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToFahrenheit, RoundBy);

            Assert.AreEqual(expected, actual);
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
