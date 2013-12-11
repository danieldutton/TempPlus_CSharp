using NUnit.Framework;
using TempConverter.Model.Domain;

namespace TempConverter._UnitTests.Model
{
    [TestFixture]
    public class Scale_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Scale<int>(-150, 150, 3);

            const string expected = "[Scale`1] Minimum: -150 Maximum: 150 ScaleBy: 3";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
