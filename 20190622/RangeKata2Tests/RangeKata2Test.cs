using NUnit.Framework;
using RangeKata2;
using System;

namespace RangeKata2Tests
{
    [TestFixture]
    public class RangeKata2Test
    {
        [Test]
        public void CheckingifContains_WithIntervalfrom1to1_ShouldReturnTrue(){
            bool result = new Interval("[1,1]").Contains(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckingifContains2_WithIntervalfrom1to1_ShouldReturnFalse()
        {
            bool result = new Interval("[1,1]").Contains(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckingifContains1_WithIntervalfrom2to3_ShouldReturnFalse()
        {
            bool result = new Interval("[2,3]").Contains(1);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckingifContains2_WithIntervalfromopen2to3_ShouldReturnFalse()
        {
            bool result = new Interval("(2,3]").Contains(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void GettingAllPoints_WithIntervalfrom2to13_ShouldReturnNumbersfrom2to13()
        {
            string expected = "{2,3,4,5,6,7,8,9,10,11,12,13}";
            string result = new Interval("[2,13]").GetAllPoints();
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void GettingAllPoints_WithIntervalfromOpenNegative4to3_ShouldReturnNumbersfrom2to13()
        {
            string expected = "{-3,-2,-1,0,1,2,3}";
            string result = new Interval("(-4,3]").GetAllPoints();
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void CheckingIfContainsRange_WithTwoEqualIntervals_ShouldReturnTrue()
        {
            bool result = new Interval("[3,9]").ContainsRange("[3,9]");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckingIfContainsRange_WithDifferentIntervals_ShouldReturnFalse()
        {
            bool result = new Interval("[3,5]").ContainsRange("[4,9]");
            Assert.IsFalse(result);
        }

        [Test]
        public void GettingEndPoints_WithIntervalfromOpen10toOpen13_ShouldReturn11and12()
        {
            string expected = "{11,12}";
            string result = new Interval("(10,13)").EndPoints();
            Assert.AreEqual(expected, result);
        }
    }
}
