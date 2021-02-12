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
    }
}