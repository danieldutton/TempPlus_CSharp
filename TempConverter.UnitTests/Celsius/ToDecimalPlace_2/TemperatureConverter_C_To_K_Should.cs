using NUnit.Framework;
using TempConverter.Model;

namespace TempConverter.UnitTests.Celsius.ToDecimalPlace_2
{
    [TestFixture]
    public class TemperatureConverter_C_To_K_Should
    {
        private ConversionFormula _celsiusToKelvin;

        private StandardTemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _celsiusToKelvin = StandardTemperatureConverter.CelsiusToKelvin;
            _sut = new StandardTemperatureConverter();
        }

        #region Celsius To Kelvin Positive Values

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_0_To_10_RoundedTo2DP([Range(0d, 10d, 1d)]double temperature,
                    [Values(273.15, 274.15, 275.15, 276.15, 277.15, 278.15, 279.15, 280.15, 281.15, 282.15, 283.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_11_To_20_RoundedTo2DP([Range(11.0d, 20d, 1d)]double temperature,
                    [Values(284.15, 285.15, 286.15, 287.15, 288.15, 289.15, 290.15, 291.15, 292.15, 293.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_21_To_30_RoundedTo2DP([Range(21d, 30d, 1d)]double temperature,
                    [Values(294.15, 295.15, 296.15, 297.15, 298.15, 299.15, 300.15, 301.15, 302.15, 303.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_31_To_40_RoundedTo2DP([Range(31d, 40d, 1d)]double temperature,
                    [Values(304.15, 305.15, 306.15, 307.15, 308.15, 309.15, 310.15, 311.15, 312.15, 313.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_41_To_50_RoundedTo2DP([Range(41d, 50d, 1d)]double temperature,
                    [Values(314.15, 315.15, 316.15, 317.15, 318.15, 319.15, 320.15, 321.15, 322.15, 323.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_51_To_60_RoundedTo2DP([Range(51d, 60d, 1d)]double temperature,
                    [Values(324.15, 325.15, 326.15, 327.15, 328.15, 329.15, 330.15, 331.15, 332.15, 333.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_61_To_70_RoundedTo2DP([Range(61d, 70d, 1d)]double temperature,
                    [Values(334.15, 335.15, 336.15, 337.15, 338.15, 339.15, 340.15, 341.15, 342.15, 343.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }


        #endregion

        #region Celsius To Kelvin Negative Values
   
        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg100_To_Neg90_RoundedTo2DP([Range(-100d, -90d, 1d)]double temperature,
                    [Values(173.15, 174.15, 175.15, 176.15, 177.15, 178.15, 179.15, 180.15, 181.15, 182.15, 183.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89d, -80d, 1d)]double temperature,
                    [Values(184.15, 185.15, 186.15, 187.15, 188.15, 189.15, 190.15, 191.15, 192.15, 193.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79d, -70d, 1d)]double temperature,
                    [Values(194.15, 195.15, 196.15, 197.15, 198.15, 199.15, 200.15, 201.15, 202.15, 203.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69d, -60d, 1d)]double temperature,
                    [Values(204.15, 205.15, 206.15, 207.15, 208.15, 209.15, 210.15, 211.15, 212.15, 213.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59d, -50d, 1d)]double temperature,
                    [Values(214.15, 215.15, 216.15, 217.15, 218.15, 219.15, 220.15, 221.15, 222.15, 223.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49d, -40d, 1d)]double temperature,
                    [Values(224.15, 225.15, 226.15, 227.15, 228.15, 229.15, 230.15, 231.15, 232.15, 233.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39d, -30d, 1d)]double temperature,
                    [Values(234.15, 235.15, 236.15, 237.15, 238.15, 239.15, 240.15, 241.15, 242.15, 243.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29d, -20d, 1d)]double temperature,
                    [Values(244.15, 245.15, 246.15, 247.15, 248.15, 249.15, 250.15, 251.15, 252.15, 253.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19d, -10d, 1d)]double temperature,
                    [Values(254.15, 255.15, 256.15, 257.15, 258.15, 259.15, 260.15, 261.15, 262.15, 263.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertCelsiusToKelvinRange_Neg9_To_0_RoundedTo2DP([Range(-9d, 0d, 1d)]double temperature,
                    [Values(264.15, 265.15, 266.15, 267.15, 268.15, 269.15, 270.15, 271.15, 272.15, 273.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _celsiusToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
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
