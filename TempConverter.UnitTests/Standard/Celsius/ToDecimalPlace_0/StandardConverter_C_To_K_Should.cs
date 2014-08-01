using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Celsius.ToDecimalPlace_0
{
    [TestFixture]
    public class StandardConverter_C_To_K_Should
    {
        private ConversionFormula _celsiusToKelvin;

        private ITemperatureConverter _sut;

        private const int RoundBy = 0;

        [SetUp]
        public void Init()
        {
            _celsiusToKelvin = StandardConverter.CelsiusToKelvin;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_0_To_10_RoundedTo0DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283)]double expected)
        {

            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_11_To_20_RoundedTo0DP([Range(11.0d, 20d, 1d)]double temperature,
                    [Values(284, 285, 286, 287, 288, 289, 290, 291, 292, 293)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_21_To_30_RoundedTo0DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(294, 295, 296, 297, 298, 299, 300, 301, 302, 303)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_31_To_40_RoundedTo0DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(304, 305, 306, 307, 308, 309, 310, 311, 312, 313)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_41_To_50_RoundedTo0DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(314, 315, 316, 317, 318, 319, 320, 321, 322, 323)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_51_To_60_RoundedTo0DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(324, 325, 326, 327, 328, 329, 330, 331, 332, 333)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_61_To_70_RoundedTo0DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(334, 335, 336, 337, 338, 339, 340, 341, 342, 343)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        
        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_71_To_80_RoundedTo0DP([Range(71d, 80d, 1d)]double temperature,
                    [Values(344, 345, 346, 347, 348, 349, 350, 351, 352, 353)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_81_To_90_RoundedTo0DP([Range(81d, 90d, 1d)]double temperature,
                    [Values(354, 355, 356, 357, 358, 359, 360, 361, 362, 363)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_91_To_100_RoundedTo0DP([Range(91d, 100d, 1d)]double temperature,
                    [Values(364, 365, 366, 367, 368, 369, 370, 371, 372, 373)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_101_To_110_RoundedTo0DP([Range(101d, 110d, 1d)]double temperature,
                    [Values(374, 375, 376, 377, 378, 379, 380, 381, 382, 383)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        
        #endregion

        #region Negative Values


        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg140_To_Neg130_RoundedTo0DP([Range(-140d, -130d, 1d)]double temperature,
                    [Values(133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg129_To_Neg120_RoundedTo0DP([Range(-129d, -120d, 1d)]double temperature,
                    [Values(144, 145, 146, 147, 148, 149, 150, 151, 152, 153)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg119_To_Neg110_RoundedTo0DP([Range(-119d, -110d, 1d)]double temperature,
                    [Values(154, 155, 156, 157, 158, 159, 160, 161, 162, 163)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg109_To_Neg100_RoundedTo0DP([Range(-109d, -100d, 1d)]double temperature,
                    [Values(164, 165, 166, 167, 168, 169, 170, 171, 172, 173)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }
        
        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg99_To_Neg90_RoundedTo0DP([Range(-99d, -90d, 1d)]double temperature,
                    [Values(174, 175, 176, 177, 178, 179, 180, 181, 182, 183)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg89_To_Neg80_RoundedTo0DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(184, 185, 186, 187, 188, 189, 190, 191, 192, 193)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg79_To_Neg70_RoundedTo0DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(194, 195, 196, 197, 198, 199, 200, 201, 202, 203)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg69_To_Neg60_RoundedTo0DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(204, 205, 206, 207, 208, 209, 210, 211, 212, 213)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg59_To_Neg50_RoundedTo0DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(214, 215, 216, 217, 218, 219, 220, 221, 222, 223)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg49_To_Neg40_RoundedTo0DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(224, 225, 226, 227, 228, 229, 230, 231, 232, 233)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg39_To_Neg30_RoundedTo0DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(234, 235, 236, 237, 238, 239, 240, 241, 242, 243)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg29_To_Neg20_RoundedTo0DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(244, 245, 246, 247, 248, 249, 250, 251, 252, 253)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg19_To_Neg10_RoundedTo0DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(254, 255, 256, 257, 258, 259, 260, 261, 262, 263)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg9_To_0_RoundedTo0DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(264, 265, 266, 267, 268, 269, 270, 271, 272, 273)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _celsiusToKelvin = null;
            _sut = null;
        }
    }
}
