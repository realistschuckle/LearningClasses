using System;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players?");
            string humanInput = Console.ReadLine();
            int numberOfPlayers = Int32.Parse(humanInput);

            PigDieGame game = new PigDieGame();
            game.Start(numberOfPlayers);
            
            Console.ReadLine();
        }
    }
}
