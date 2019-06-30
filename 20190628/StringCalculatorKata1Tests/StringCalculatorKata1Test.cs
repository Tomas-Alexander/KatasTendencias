using NUnit.Framework;
using StringCalculatorKata1;
using System;

namespace StringCalculatorKata1Tests
{
    [TestFixture]
    public class StringCalculatorKata1Test
    {
        [Test]
        public void CalculatingString_WithEmptyString_ShouldReturn0()
        {
            string result = Calculator.Add("");
            string expected = "0";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingString_WithNumberOne_ShouldReturn1()
        {
            string result = Calculator.Add("1");
            string expected = "1";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingString_WithNumbersOneTwoAndThree_ShouldReturn6()
        {
            string result = Calculator.Add("1,2,3");
            string expected = "6";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingString_WithDecimals_ShouldReturnDecimal()
        {
            string result = Calculator.Add("1.3,2,3.34");
            string expected = "6.64";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingString_WithNewLineSeparator_ShouldReturnExpectedValue()
        {
            string result = Calculator.Add("2\n3.4,4,6\n8.63");
            string expected = "24.03";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingString_WithMissingNumberInLastPosition_ShouldThrowException()
        {
            Assert.Throws(typeof(ArgumentException), delegate { Calculator.Add("3.4,5\n6,"); });

        }

        [Test]
        public void CalculatingString_WithCustomSeparator_ShouldReturnExpectedValue()
        {
            string result = Calculator.Add("//sep\n2sep3");
            string expected = "5";
            Assert.AreEqual(expected, result);
        }

    }
}
