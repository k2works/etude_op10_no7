﻿namespace lib
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;
        private int currentFrame = 1;
        private bool isFirstThrow = true;

        public int CurrentFrame
        {
            get { return currentFrame; }
        }

        public int Score()
        {
            return ScoreForFrame(CurrentFrame - 1);
        }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;

            AdjustCurrentFrame();
        }

        private void AdjustCurrentFrame()
        {
            if (isFirstThrow)
            {
                isFirstThrow = false;
            }
            else
            {
                isFirstThrow = true;
                currentFrame++;
            }
        }

        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for(int currentFrame = 0;
                currentFrame < theFrame;
                currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];

                int frameScore = firstThrow + secondThrow;

                // spare needs next frames first throw
                if (frameScore == 10)
                    score += frameScore + throws[ball];
                else
                    score += frameScore;
            }

            return score;
        }
    }
}