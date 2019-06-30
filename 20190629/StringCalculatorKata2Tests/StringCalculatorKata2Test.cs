using NUnit.Framework;
using StringCalculatorKata2;

namespace StringCalculatorKata2Tests
{
    [TestFixture]
    public class StringCalculatorKata2Test
    {
        [Test]
        public void Calculating_WithEmptyString_ShouldReturn0()
        {
            string result = StringCalculator.Add("");
            Assert.AreEqual("0", result);
        }

        [Test]
        public void Calculating_WithJustOneNumber_ShouldReturnTheNumber()
        {
            string result = StringCalculator.Add("1");
            Assert.AreEqual("1", result);
        }

        [Test]
        public void Calculating_With1And2_ShouldReturn3()
        {
            string result = StringCalculator.Add("1,2");
            Assert.AreEqual("3", result);
        }

        [Test]
        public void Calculating_WithDecimals_ShouldReturnExpectedValue()
        {
            string result = StringCalculator.Add("1.1,2.2");
            Assert.AreEqual("3.3", result);
        }

        [Test]
        public void Calculating_WithNewLinesAsSeparator_ShouldReturnExpectedValue()
        {
            string result = StringCalculator.Add("1\n2,3");
            Assert.AreEqual("6", result);
        }

        [Test]
        public void Calculating_WithNewLineAndWrongFormat_ShouldReturnErrorMessage()
        {
            string result = StringCalculator.Add("175.2,\n35");
            Assert.AreEqual("Number expected but '\n' found at position 6.", result);
        }

        [Test]
        public void Calculating_WithMissingNumberInLastPosition_ShouldReturnErrorMessage()
        {
            string result = StringCalculator.Add("1,3,");
            Assert.AreEqual("Number expected but EOF found.", result);
        }

        [Test]
        public void Calculating_WithCustomSeparator_ShouldReturnExpectedvalue()
        {
            string result = StringCalculator.Add("//|\n1|2|3");
            Assert.AreEqual("6", result);
        }
    }
}
