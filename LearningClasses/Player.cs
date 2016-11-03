using System;

namespace LearningClasses
{
    public class Player
    {
        private Random die;
        private int myRoll;
        private int accumulatedTurnScore;
        private int heldScore;

        // constructor
        public Player()
        {
            die = new Random();
        }

        public void RollTheDie()
        {
            myRoll = die.Next(1, 7);
        }

        public int WhatNumberDidYouRoll()
        {
            return myRoll;
        }

        public void SetYourTurnAccumulator(int value)
        {
            accumulatedTurnScore = value;
        }

        public void AddYourCurrentRollToTheTurnScore()
        {
            accumulatedTurnScore = accumulatedTurnScore + myRoll;
        }

        public bool IsYourGrandTotalMoreThan100()
        {
            int grandTotal = accumulatedTurnScore + heldScore;

            if (grandTotal >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAccumulatedTurnScoreToTotalScoreAndZeroAccumulator()
        {
            heldScore = heldScore + accumulatedTurnScore;
            accumulatedTurnScore = 0;
        }

        public void PrintScoreStatus()
        {
            Console.WriteLine("Your turn score is: " + accumulatedTurnScore);
            Console.WriteLine("You have " + heldScore + " saved.");
        }
    }
}
