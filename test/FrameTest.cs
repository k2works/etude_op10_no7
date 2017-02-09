using lib;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class FrameTest
    {
        [Test]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.Score);
        }
    }
}