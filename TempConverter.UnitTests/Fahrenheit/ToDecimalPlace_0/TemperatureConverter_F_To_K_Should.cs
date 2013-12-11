using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter._UnitTests.Fahrenheit.ToDecimalPlace_0
{
    [TestFixture]
    public class TemperatureConverter_F_To_K_Should
    {
        private ConversionFormula _fahrenheitToKelvin;

        private ITemperatureConverter _temperatureConverter;

        private const int RoundBy = 0;

        [SetUp]
        public void Init()
        {
            _fahrenheitToKelvin = TemperatureConverter.FahrenheitToKelvin;
            _temperatureConverter = new TemperatureConverter();
        }

        #region Fahrenheit To Kelvin Positive Values

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_0_To_10_RoundedTo0DP([Range(0, 10, 1)]double temperature,
                    [Values(255, 256, 256, 257, 258, 258, 259, 259, 260, 260, 261)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_11_To_20_RoundedTo0DP([Range(11, 20, 1)]double temperature,
                    [Values(261, 262, 263, 263, 264, 264, 265, 265, 266, 266)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_21_To_30_RoundedTo0DP([Range(21, 30, 1)]double temperature,
                    [Values(267, 268, 268, 269, 269, 270, 270, 271, 271, 272)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_31_To_40_RoundedTo0DP([Range(31, 40, 1)]double temperature,
                    [Values(273, 273, 274, 274, 275, 275, 276, 276, 277, 278)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_41_To_50_RoundedTo0DP([Range(41, 50, 1)]double temperature,
                    [Values(278, 279, 279, 280, 280, 281, 281, 282, 283, 283)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_51_To_60_RoundedTo0DP([Range(51, 60, 1)]double temperature,
                    [Values(284, 284, 285, 285, 286, 286, 287, 288, 288, 289)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_61_To_70_RoundedTo0DP([Range(61, 70, 1)]double temperature,
                    [Values(289, 290, 290, 291, 291, 292, 293, 293, 294, 294)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_71_To_80_RoundedTo0DP([Range(71, 80, 1)]double temperature,
                    [Values(295, 295, 296, 296, 297, 298, 298, 299, 299, 300)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_81_To_90_RoundedTo0DP([Range(81, 90, 1)]double temperature,
                    [Values(300, 301, 301, 302, 303, 303, 304, 304, 305, 305)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_91_To_100_RoundedTo0DP([Range(91, 100, 1)]double temperature,
                    [Values(306, 306, 307, 308, 308, 309, 309, 310, 310, 311)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_101_To_110_RoundedTo0DP([Range(101, 110, 1)]double temperature,
                    [Values(311, 312, 313, 313, 314, 314, 315, 315, 316, 316)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_111_To_120_RoundedTo0DP([Range(111, 120, 1)]double temperature,
                    [Values(317, 318, 318, 319, 319, 320, 320, 321, 321, 322)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_121_To_130_RoundedTo0DP([Range(121, 130, 1)]double temperature,
                    [Values(323, 323, 324, 324, 325, 325, 326, 326, 327, 328)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_131_To_140_RoundedTo0DP([Range(131, 140, 1)]double temperature,
                    [Values(328, 329, 329, 330, 330, 331, 331, 332, 333, 333)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_141_To_150_RoundedTo0DP([Range(141, 150, 1)]double temperature,
                    [Values(334, 334, 335, 335, 336, 336, 337, 338, 338, 339)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Fahrenheit To Kelvin Negative Values

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg150_To_Neg140_RoundedTo0DP([Range(-150, -140, 1)]double temperature,
                    [Values(172, 173, 173, 174, 174, 175, 175, 176, 176, 177, 178)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg139_To_Neg130_RoundedTo0DP([Range(-139, -130, 1)]double temperature,
                    [Values(178, 179, 179, 180, 180, 181, 181, 182, 183, 183)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg129_To_Neg120_RoundedTo0DP([Range(-129, -120, 1)]double temperature,
                    [Values(184, 184, 185, 185, 186, 186, 187, 188, 188, 189)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg119_To_Neg110_RoundedTo0DP([Range(-119, -110, 1)]double temperature,
                    [Values(189, 190, 190, 191, 191, 192, 193, 193, 194, 194)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg109_To_Neg100_RoundedTo0DP([Range(-109, -100, 1)]double temperature,
                    [Values(195, 195, 196, 196, 197, 198, 198, 199, 199, 200)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg99_To_Neg90_RoundedTo0DP([Range(-99, -90, 1)]double temperature,
                    [Values(200, 201, 201, 202, 203, 203, 204, 204, 205, 205)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg89_To_Neg80_RoundedTo0DP([Range(-89, -80, 1)]double temperature,
                    [Values(206, 206, 207, 208, 208, 209, 209, 210, 210, 211)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg79_To_Neg70_RoundedTo0DP([Range(-79, -70, 1)]double temperature,
                    [Values(211, 212, 213, 213, 214, 214, 215, 215, 216, 216)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg69_To_Neg60_RoundedTo0DP([Range(-69, -60, 1)]double temperature,
                    [Values(217, 218, 218, 219, 219, 220, 220, 221, 221, 222)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg59_To_Neg50_RoundedTo0DP([Range(-59, -50, 1)]double temperature,
                    [Values(223, 223, 224, 224, 225, 225, 226, 226, 227, 228)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg49_To_Neg40_RoundedTo0DP([Range(-49, -40, 1)]double temperature,
                    [Values(228, 229, 229, 230, 230, 231, 231, 232, 233, 233)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg39_To_Neg30_RoundedTo0DP([Range(-39, -30, 1)]double temperature,
                    [Values(234, 234, 235, 235, 236, 236, 237, 238, 238, 239)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg29_To_Neg20_RoundedTo0DP([Range(-29, -20, 1)]double temperature,
                    [Values(239, 240, 240, 241, 241, 242, 243, 243, 244, 244)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg19_To_Neg10_RoundedTo0DP([Range(-19, -10, 1)]double temperature,
                    [Values(245, 245, 246, 246, 247, 248, 248, 249, 249, 250)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg9_To_Neg0_RoundedTo0DP([Range(-9, 0, 1)]double temperature,
                    [Values(250, 251, 251, 252, 253, 253, 254, 254, 255, 255)]double expected)
        {
            double actual = _temperatureConverter.ConvertTemperature(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _fahrenheitToKelvin = null;
            _temperatureConverter = null;
        }

    }
}
