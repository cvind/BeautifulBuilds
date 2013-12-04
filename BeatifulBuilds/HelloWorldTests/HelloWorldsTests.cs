using NUnit.Framework;

namespace HelloWorldTests
{
    [TestFixture]
    public class HelloWorldsTests
    {
        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(true, false);
        }

        [Test]
        public void SucceedingTest()
        {
            Assert.AreEqual(true, true);
        }

        [Test]
        public void InconclusiveTest()
        {
            Assert.Inconclusive();
        }
    }
}
