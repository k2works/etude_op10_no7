namespace lib
{
    public class Game
    {
        private int score;

        public int Score
        {
            get { return score; }
        }

        public void Add(int pins)
        {
            score += pins;
        }

        public int ScoreForFrame(int frame)
        {
            return 0;
        }
    }
}