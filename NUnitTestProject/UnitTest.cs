using NUnit.Framework;
using TestMaximumNameSpace;

namespace NUnitTestProject
{
    public class Tests
    {
        TestMaximum testMaximum;

        [SetUp]
        public void Setup()
        {
            testMaximum = new TestMaximum();
        }
        //FIND MAXIMUM INTEGER
        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(76, 50, 34);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(50, 76, 34);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(50, 34, 76);
            Assert.AreEqual(76, result);
        }

        //FIND MAXIMUM FLOAT
        [Test]
        public void GivenMaxFlaot_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            float result = testMaximum.GetMaximumFlaot(76.1f, 50.2f, 34.3f);
            Assert.AreEqual(76.1f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            float result = testMaximum.GetMaximumFlaot(50.2f, 76.1f, 34.3f);
            Assert.AreEqual(76.1f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            float result = testMaximum.GetMaximumFlaot(50.2f, 34.3f, 76.1f);
            Assert.AreEqual(76.1f, result);
        }

        //FIND MAXIMUM STRING
        [Test]
        public void GivenMaxString_AtFirstPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("Zebra", "lion", "zebra");
            Assert.AreEqual("Zebra", result);
        }

        [Test]
        public void GivenMaxString_AtSeconndPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("zebra", "Zebra", "lion");
            Assert.AreEqual("Zebra", result);
        }
    }
}