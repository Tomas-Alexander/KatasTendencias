using NUnit.Framework;
using RomanNumeralsKata1;

namespace RomanNumeralsKata1Tests
{
    [TestFixture]
    public class RomanNumeralsKata1Test
    {
        [Test]
        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void FromNumberToRoman_WithNumbersFromOneToTen_ShoulReturnExpectedValue(int number, string expected)
        {
            string result = Number.ToRoman(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        public void FromNumberToRoman_WithNumbersFromElevenToTwenty_ShouldReturnExpected(int number, string expected)
        {
            string result = Number.ToRoman(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FromNumberToRoman_WithNumberTwelve_ShouldReturnXII()
        {
            string result = Number.ToRoman(12);
            Assert.AreEqual("XII", result);
        }
    }
}
