using NUnit.Framework;
using TempConverter.Model;
using TempConverter.Model.Interfaces;

namespace TempConverter.UnitTests.Standard.Fahrenheit.ToDecimalPlace_2
{
    [TestFixture]
    public class StandardConverter_F_To_K_Should
    {
        private ConversionFormula _fahrenheitToKelvin;

        private ITemperatureConverter _sut;

        private const int RoundBy = 2;

        private readonly double _toleranceLevel = Mother.ToleranceLevel;

        [SetUp]
        public void Init()
        {
            _fahrenheitToKelvin = StandardConverter.FahrenheitToKelvin;
            _sut = new StandardConverter();
        }

        #region Positive Values

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_0_To_10_RoundedTo2DP([Range(0, 10, 1)]double temperature,
                    [Values(255.37, 255.92, 256.48, 257.03, 257.59, 258.15, 258.706, 259.261, 259.817, 260.372, 260.928)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_11_To_20_RoundedTo2DP([Range(11, 20, 1)]double temperature,
                    [Values(261.48, 262.04, 262.59, 263.15, 263.71, 264.26, 264.82, 265.37, 265.93, 266.48)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_21_To_30_RoundedTo2DP([Range(21, 30, 1)]double temperature,
                    [Values(267.04, 267.59, 268.15, 268.71, 269.26, 269.82, 270.37, 270.93, 271.48, 272.04)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_31_To_40_RoundedTo2DP([Range(31, 40, 1)]double temperature,
                    [Values(272.59, 273.15, 273.71, 274.26, 274.82, 275.37, 275.93, 276.48, 277.04, 277.59)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_41_To_50_RoundedTo2DP([Range(41, 50, 1)]double temperature,
                    [Values(278.15, 278.71, 279.26, 279.82, 280.37, 280.93, 281.48, 282.04, 282.59, 283.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_51_To_60_RoundedTo2DP([Range(51, 60, 1)]double temperature,
                    [Values(283.71, 284.26, 284.82, 285.37, 285.93, 286.48, 286.48, 287.59, 288.15, 288.71)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_61_To_70_RoundedTo2DP([Range(61, 70, 1)]double temperature,
                    [Values(289.26, 289.82, 290.37, 290.93, 291.48, 292.04, 292.59, 293.15, 293.71, 294.26)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_71_To_80_RoundedTo2DP([Range(71, 80, 1)]double temperature,
                    [Values(294.82, 295.37, 295.93, 296.48, 297.04, 297.59, 298.15, 298.71, 299.26, 299.82)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_81_To_90_RoundedTo2DP([Range(81, 90, 1)]double temperature,
                    [Values(300.37, 300.93, 301.483, 302.04, 302.59, 303.15, 303.71, 304.26, 304.82, 305.37)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_91_To_100_RoundedTo2DP([Range(91, 100, 1)]double temperature,
                    [Values(305.37, 306.483, 307.04, 307.60, 308.15, 308.71, 309.26, 309.82, 310.37, 310.93)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_101_To_110_RoundedTo2DP([Range(101, 110, 1)]double temperature,
                    [Values(311.48, 312.04, 312.59, 313.15, 313.71, 314.26, 314.82, 315.37, 315.93, 316.48)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_111_To_120_RoundedTo2DP([Range(111, 120, 1)]double temperature,
                    [Values(317.04, 317.60, 318.15, 318.71, 319.26, 319.82, 320.37, 320.93, 321.48, 322.04)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_121_To_130_RoundedTo2DP([Range(121, 130, 1)]double temperature,
                    [Values(322.59, 323.15, 323.71, 324.26, 324.82, 325.37, 325.93, 326.48, 327.03, 327.59)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_131_To_140_RoundedTo2DP([Range(131, 140, 1)]double temperature,
                    [Values(328.15, 328.71, 329.26, 329.82, 330.37, 330.93, 331.48, 332.04, 332.59, 333.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_141_To_150_RoundedTo2DP([Range(141, 150, 1)]double temperature,
                    [Values(333.71, 334.26, 334.82, 335.37, 335.93, 336.48, 337.04, 337.59, 338.15, 338.71)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_151_To_160_RoundedTo2DP([Range(151d, 160d, 1d)]double temperature,
                    [Values(339.26, 339.82, 340.37, 340.93, 341.48, 342.04, 342.59, 343.15, 343.71, 344.26)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_161_To_170_RoundedTo2DP([Range(161d, 170d, 1d)]double temperature,
                    [Values(344.82, 345.37, 345.93, 346.48, 347.04, 347.59, 348.15, 348.71, 349.26, 349.82)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_171_To_180_RoundedTo2DP([Range(171d, 180d, 1d)]double temperature,
                    [Values(350.37, 350.93, 351.48, 352.04, 352.59, 353.15, 353.71, 354.26, 354.82, 355.37)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_181_To_190_RoundedTo2DP([Range(181d, 190d, 1d)]double temperature,
                    [Values(355.93, 356.48, 357.04, 357.59, 358.15, 358.71, 359.26, 359.82, 360.37, 360.93)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_191_To_200_RoundedTo2DP([Range(191d, 200d, 1d)]double temperature,
                    [Values(361.48, 362.04, 362.59, 363.15, 363.71, 364.26, 364.82, 365.37, 365.93, 366.48)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_201_To_210_RoundedTo2DP([Range(201d, 210d, 1d)]double temperature,
                    [Values(367.04, 367.59, 368.15, 368.71, 369.26, 369.82, 370.37, 370.93, 371.48, 372.04)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_211_To_220_RoundedTo2DP([Range(211d, 220d, 1d)]double temperature,
                    [Values(372.59, 373.15, 373.71, 374.26, 374.82, 375.37, 375.93, 376.48, 377.04, 377.59)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Negative Values

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg220_To_Neg210_RoundedTo2DP([Range(-220d, -210d, 1d)]double temperature,
                    [Values(133.15, 133.71, 134.26, 134.82, 135.37, 135.93, 136.48, 137.04, 137.59, 138.15, 138.71)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg209_To_Neg200_RoundedTo2DP([Range(-209d, -200d, 1d)]double temperature,
                    [Values(139.26, 139.82, 140.37, 140.93, 141.48, 142.04, 142.59, 143.15, 143.71, 144.26)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg199_To_Neg190_RoundedTo2DP([Range(-199d, -190d, 1d)]double temperature,
                    [Values(144.82, 145.37, 145.93, 146.48, 147.04, 147.59, 148.15, 148.71, 149.26, 149.82)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg189_To_Neg180_RoundedTo2DP([Range(-189d, -180d, 1d)]double temperature,
                    [Values(150.37, 150.93, 151.48, 152.04, 152.59, 153.15, 153.71, 154.26, 154.82, 155.37)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg179_To_Neg170_RoundedTo2DP([Range(-179d, -170d, 1d)]double temperature,
                    [Values(155.93, 156.48, 157.04, 157.59, 158.15, 158.71, 159.26, 159.82, 160.37, 160.93)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg169_To_Neg160_RoundedTo2DP([Range(-169d, -160d, 1d)]double temperature,
                    [Values(161.48, 162.04, 162.59, 163.15, 163.71, 164.26, 164.82, 165.37, 165.93, 166.48)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg159_To_Neg150_RoundedTo2DP([Range(-159d, -150d, 1d)] double temperature,
            [Values(167.04, 167.59, 168.15, 168.71, 169.26, 169.82, 170.37, 170.93, 171.48, 172.04)] double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg149_To_Neg140_RoundedTo2DP([Range(-149, -140, 1)]double temperature,
                    [Values(172.59, 173.15, 173.71, 174.26, 174.82, 175.37, 175.93, 176.48, 177.04, 177.59)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg139_To_Neg130_RoundedTo2DP([Range(-139, -130, 1)]double temperature,
                    [Values(178.15, 178.71, 179.26, 179.82, 180.37, 180.93, 181.48, 182.04, 182.59, 183.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg129_To_Neg120_RoundedTo2DP([Range(-129, -120, 1)]double temperature,
                    [Values(183.71, 184.26, 184.82, 185.37, 185.93, 186.48, 187.04, 187.59, 188.15, 188.71)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg119_To_Neg110_RoundedTo2DP([Range(-119, -110, 1)]double temperature,
                    [Values(189.26, 189.82, 190.37, 190.93, 191.48, 192.04, 192.59, 193.15, 193.71, 194.26)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg109_To_Neg100_RoundedTo2DP([Range(-109, -100, 1)]double temperature,
                    [Values(194.82, 195.37, 195.93, 196.48, 197.04, 197.59, 198.15, 198.71, 199.26, 199.82)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg99_To_Neg90_RoundedTo2DP([Range(-99, -90, 1)]double temperature,
                    [Values(200.37, 200.93, 201.48, 202.04, 202.59, 203.15, 203.71, 204.26, 204.82, 205.37)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg89_To_Neg80_RoundedTo2DP([Range(-89, -80, 1)]double temperature,
                    [Values(205.93, 206.48, 207.04, 207.59, 208.15, 208.71, 209.26, 209.82, 210.37, 210.93)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg79_To_Neg70_RoundedTo2DP([Range(-79, -70, 1)]double temperature,
                    [Values(211.48, 212.04, 212.59, 213.15, 213.71, 214.26, 214.82, 215.37, 215.93, 216.48)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg69_To_Neg60_RoundedTo2DP([Range(-69, -60, 1)]double temperature,
                    [Values(217.04, 217.59, 218.15, 218.71, 219.26, 219.82, 220.37, 220.93, 221.48, 222.04)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg59_To_Neg50_RoundedTo2DP([Range(-59, -50, 1)]double temperature,
                    [Values(222.59, 223.15, 223.71, 224.26, 224.82, 225.37, 225.93, 226.48, 227.04, 227.59)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg49_To_Neg40_RoundedTo2DP([Range(-49, -40, 1)]double temperature,
                    [Values(228.15, 228.71, 229.26, 229.82, 230.37, 230.93, 231.48, 232.04, 232.59, 233.15)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg39_To_Neg30_RoundedTo2DP([Range(-39, -30, 1)]double temperature,
                    [Values(233.71, 234.26, 234.82, 235.37, 235.93, 236.48, 237.03, 237.59, 238.15, 238.71)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg29_To_Neg20_RoundedTo2DP([Range(-29, -20, 1)]double temperature,
                    [Values(239.26, 239.82, 240.37, 240.93, 241.48, 242.04, 242.59, 243.15, 243.71, 244.26)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg19_To_Neg10_RoundedTo2DP([Range(-19, -10, 1)]double temperature,
                    [Values(244.82, 245.37, 245.93, 246.48, 247.04, 247.59, 248.15, 248.71, 249.26, 249.82)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        [Test, Sequential]
        public void ConvertFahrenheitToKelvinRange_Neg9_To_Neg0_RoundedTo2DP([Range(-9, 0, 1)]double temperature,
                    [Values(250.37, 250.93, 251.48, 252.04, 252.59, 253.15, 253.71, 254.26, 254.82, 255.37)]double expected)
        {
            double actual = _sut.Convert(temperature, _fahrenheitToKelvin, RoundBy);

            Assert.AreEqual(expected, actual, _toleranceLevel);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _fahrenheitToKelvin = null;
            _sut = null;
        }

    }
}
