namespace lib
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;

        public int Score
        {
            get { return score; }
        }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for(int currentFrame = 0;
                currentFrame < theFrame;
                currentFrame++)
            {
                score += throws[ball++] + throws[ball++];
            }

            return score;
        }
    }
}