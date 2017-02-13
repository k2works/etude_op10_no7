﻿namespace lib
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;
        private int currentFrame = 1;
        private bool isFirstThrow = true;
        private int ball;
        private int firstThrow;
        private int secondThrow;

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

            AdjustCurrentFrame(pins);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (isFirstThrow)
            {
                if (pins == 10) //Strike
                    currentFrame++;
                else
                    isFirstThrow = false;
            }
            else
            {
                isFirstThrow = true;
                currentFrame++;
            }
            if (currentFrame > 11)
                currentFrame = 11;
        }

        public int ScoreForFrame(int theFrame)
        {
            ball = 0;
            int score = 0;
            for(int currentFrame = 0;
                currentFrame < theFrame;
                currentFrame++)
            {
                firstThrow = throws[ball];
                if (firstThrow == 10) //Strike
                {
                    ball++;
                    score += 10 + throws[ball] + throws[ball + 1];
                }
                else
                {
                    score += HandleSecondThrow();
                }
            }

            return score;
        }

        private int HandleSecondThrow()
        {
            int score =0;
            secondThrow = throws[ball + 1];

            int frameScore = firstThrow + secondThrow;

            // spare needs next frames first throw
            if (frameScore == 10)
            {
                ball += 2;
                score += frameScore + throws[ball];
            }
            else
            {
                ball += 2;
                score += frameScore;
            }
            return score;
        }
    }
}