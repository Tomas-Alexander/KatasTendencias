using NumbersInWordsKata1;
using NUnit.Framework;

namespace NumbresInWordsKata1Tests
{
    [TestFixture]
    public class NumbersInWordsKata1Test
    {

        [Test]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eigth")]
        [TestCase(9, "Nine")]
        public void FromNumberToWords_WithOneDigitNumber_ReturnCorrectString(int n, string expected)
        {
            string result = Numbers.ToWords(n);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        public void FromNumberToWords_WithNumberFrom10To19_ReturnCorrectString(int n, string expected)
        {
            string result = Numbers.ToWords(n);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(20, "Twenty")]
        [TestCase(21, "Twenty One")]
        [TestCase(29, "Twenty Nine")]
        public void FromNumberToWords_WithNumberFrom20To29_ReturnCorrectString(int n, string expected)
        {
            string result = Numbers.ToWords(n);

            Assert.AreEqual(expected, result);
        }
    }
}
