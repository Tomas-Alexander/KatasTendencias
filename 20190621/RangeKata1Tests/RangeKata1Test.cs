using NUnit.Framework;
using RangeKata1;

namespace RangeKata1Tests
{
    [TestFixture]
    public class RangeKata1Test
    {
        [Test]
        public void SettingIntervalFrom1to1_SeeifContains1_ShouldReturnTrue()
        {
            bool result = new Interval("[1,1]").Contains(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void SettingIntervalFrom1to1_SeeifContains2_ShouldReturnFalse()
        {
            bool result = new Interval("[1,1]").Contains(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void SettingIntervalFrom1to2_SeeifContains2_ShouldReturnFalse()
        {
            bool result = new Interval("[1,2]").Contains(2);
            Assert.IsTrue(result);
        }

        [Test]
        public void SettingIntervalFrom1toopen2_SeeifContains2_ShouldReturnFalse()
        {
            bool result = new Interval("[1,2)").Contains(2);
            Assert.IsFalse(result);
        }

        [Test]
        public void GetAllPoints_WithIntervalfrom2toopen6_ShouldReturn4numbers()
        {
            string result = new Interval("[2,6)").getAllPoints();
            Assert.AreEqual("{2,3,4,5}", result );
        }

        [Test]
        public void ContainsRange_WithInterval2to5andInterval7to10_ShouldReturnFalse()
        {
            bool result = new Interval("[2,5)").ContainsRange("[7,10)");
        }
    }
}
