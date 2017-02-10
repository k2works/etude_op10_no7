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

        public int ScoreForFrame(int frame)
        {
            int score = 0;
            for(int ball = 0; frame > 0 && (ball < currentThrow); ball+=2, frame--)
            {
                score += throws[ball] + throws[ball + 1];
            }

            return score;
        }
    }
}