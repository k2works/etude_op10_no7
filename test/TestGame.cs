using lib;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class TestGame
    {
        [Test]
        public void TestOneThrow()
        {
            Game game = new Game();

            game.Add(5);
            Assert.AreEqual(5, game.Score);
        }

        [Test]
        public void TestTwoThrowsNoMark()
        {
            Game game = new Game();
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.Score);
        }
    }
}