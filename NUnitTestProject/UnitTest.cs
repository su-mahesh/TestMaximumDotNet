using NUnit.Framework;
using TestMaximumNameSpace;

namespace NUnitTestProject
{
    public class Tests
    {
        
        //FIND MAXIMUM INTEGER
        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>();
            int result = testMaximum.GetMaximumValue(76, 50, 34);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>();
            int result = testMaximum.GetMaximumValue(50, 76, 34);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>();
            int result = testMaximum.GetMaximumValue(50, 34, 76);
            Assert.AreEqual(76, result);
        }

        //FIND MAXIMUM FLOAT
        [Test]
        public void GivenMaxFlaot_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>();
            float result = testMaximum.GetMaximumValue(76.1f, 50.2f, 34.3f);
            Assert.AreEqual(76.1f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>();
            float result = testMaximum.GetMaximumValue(50.2f, 76.1f, 34.3f);
            Assert.AreEqual(76.1f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>();
            float result = testMaximum.GetMaximumValue(50.2f, 34.3f, 76.1f);
            Assert.AreEqual(76.1f, result);
        }

        //FIND MAXIMUM STRING
        [Test]
        public void GivenMaxString_AtFirstPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>();
            string result = testMaximum.GetMaximumValue("Zebra", "lion", "zebra");
            Assert.AreEqual("Zebra", result);
        }

        [Test]
        public void GivenMaxString_AtSeconndPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>();
            string result = testMaximum.GetMaximumValue("zebra", "Zebra", "lion");
            Assert.AreEqual("Zebra", result);
        }

        [Test]
        public void GivenMaxString_AtThirdPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>();
            string result = testMaximum.GetMaximumValue("Zebra", "lion", "zebra");
            Assert.AreEqual("Zebra", result);
        }
    }
}