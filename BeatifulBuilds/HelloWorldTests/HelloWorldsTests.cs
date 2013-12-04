using NUnit.Framework;

namespace HelloWorldTests
{
    [TestFixture]
    class HelloWorldsTests
    {
        [Test]
        void FailingTest()
        {
            Assert.AreEqual(true, false);
        }

        [Test]
        void SucceedingTest()
        {
            Assert.AreEqual(true, true);
        }

        [Test]
        void InconclusiveTest()
        {
            Assert.Inconclusive();
        }
    }
}
