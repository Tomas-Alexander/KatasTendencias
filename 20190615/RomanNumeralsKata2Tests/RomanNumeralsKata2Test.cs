using NUnit.Framework;
using RomanNumeralsKata2;

namespace RomanNumeralsKata2Tests
{
    [TestFixture]
    public class RomanNumeralsKata2Test
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void FromNumberToRoman_WithNumberOne_ShoulReturnI(int number, string expected)
        {
            string result = Roman.Parse(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FromNumberToRoman_WithNumberEleven_shouldReturnXI()
        {
            string result = Roman.Parse(11);

            Assert.AreEqual("XI", result);
        }
    }
}
