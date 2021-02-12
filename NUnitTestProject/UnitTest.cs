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

        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(76, 50, 34);
            Assert.AreEqual(76, result);
        }
    }
}