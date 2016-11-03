using System;

namespace LearningClasses
{
    public class PigDieGame
    {
        private Player currentPlayer;
        private int currentPlayerIndex;
        private Player[] players;

        // visibility return-type Name(data-type name)
        public void Start(int numberOfPlayers)
        {
            players = new Player[numberOfPlayers];

            for (int i = 0; i < players.Length; i = i + 1)
            {
                players[i] = new Player();
            }

            currentPlayer = players[0];
            int numberRolled;
            bool thePlayerWon = false;

            while (!thePlayerWon)
            {
                Console.WriteLine("PLAYER " + (currentPlayerIndex + 1) + ": Roll the die!");
                currentPlayer.RollTheDie();
                numberRolled = currentPlayer.WhatNumberDidYouRoll();
                Console.WriteLine("You rolled a " + numberRolled);

                if (numberRolled == 1)
                {
                    currentPlayer.SetYourTurnAccumulator(0);
                    Console.WriteLine("You are a ...~~~~LOSER~~~....!!!!");
                    GoToTheNextPlayer();
                }
                else
                {
                    currentPlayer.AddYourCurrentRollToTheTurnScore();
                    thePlayerWon = currentPlayer.IsYourGrandTotalMoreThan100();
                    if (thePlayerWon)
                    {
                        Console.WriteLine("YOU WON! CONGRATULATIONS! YOU ARE THE PIG!");
                    }
                    else
                    {
                        currentPlayer.PrintScoreStatus();

                        Console.WriteLine("Would you like to 'hold' or 'roll'?");
                        string holdOrRoll = Console.ReadLine();
                        if (holdOrRoll == "hold")
                        {
                            currentPlayer.AddAccumulatedTurnScoreToTotalScoreAndZeroAccumulator();

                            GoToTheNextPlayer();
                        }
                        else // we're going with the roll
                        {

                        }
                    }
                }
            }
        }

        private void GoToTheNextPlayer()
        {
            // Calculate the index of thenext player in the list
            currentPlayerIndex = currentPlayerIndex + 1;

            // If we've gone beyond the end of the list,
            // then go back to the beginning of the list
            // which is the 0 index.
            if (currentPlayerIndex == players.Length)
            {
                currentPlayerIndex = 0;
            }

            // Set the current player to the correct person
            // in the list.
            currentPlayer = players[currentPlayerIndex];
        }
    }
}
