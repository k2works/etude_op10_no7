using System;

namespace lib
{
    public class Game
    {
        private int score;
        private int currentFrame = 1;
        private bool isFirstThrow = true;
        private Scorer scorer = new Scorer();

        public int Score
        {
            get { return ScoreForFrame(CurrentFrame); }
        }

        public int CurrentFrame
        {
            get { return currentFrame; }
        }

        public void Add(int pins)
        {
            scorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        public int ScoreForFrame(int theFrame)
        {
            return scorer.ScoreForFrame(theFrame);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if ((isFirstThrow && pins == 10) || (!isFirstThrow))
            {
                AdvanceFrame();
                isFirstThrow = true;
            }
            else
                isFirstThrow = false;
        }

        private bool AdjustFrameForStrike(int pins)
        {
            if (pins == 10)
            {
                AdvanceFrame();
                return true;
            }
            return false;
        }

        private void AdvanceFrame()
        {
            currentFrame++;
            if (currentFrame > 10)
                currentFrame = 10;
        }
    }
}