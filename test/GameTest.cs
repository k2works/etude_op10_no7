using lib;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void TestOneThrow()
        {
            Game game = new Game();

            game.Add(5);
            Assert.AreEqual(5, game.Score);
        }
    }
}