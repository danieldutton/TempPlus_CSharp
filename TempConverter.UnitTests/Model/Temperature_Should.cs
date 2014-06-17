using NUnit.Framework;
using TempConverter.Model.Domain;

namespace TempConverter.UnitTests.Model
{
    [TestFixture]
    public class Temperature_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Temperature<int>(fahrenheit:-150, celsius: 150, kelvin: 3);

            const string expected = "[Temperature`1] Fahrenheit: -150 Celsius: 150 Kelvin: 3";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);  
        }
    }
}
