using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopApplication = false;
            int highscore =100;
            while (stopApplication == false) {
                Console.WriteLine("");
                Console.WriteLine("Welcome on Mastermind!");
                Console.WriteLine("Do you want to start a new game?(yes/no)");
                Console.WriteLine("Or do you want to see your highscore(h)");

                string inputGame = Console.ReadLine();

                if(inputGame == "yes")
                {
                    Game game = new Game();
                    game.createGame();

                    if(highscore > game.finalGuesses)
                    {
                        highscore = game.finalGuesses;
                        Console.WriteLine("Congratulation, you have a new highscore.");
                        Console.WriteLine("In your best game you guessed the code in " + highscore + " guesses");
                    }

                }
                else if (inputGame == "no")
                {
                    stopApplication = true;
                }
                else if (inputGame == "h")
                {
                    Console.WriteLine("In your best game you guessed the code in " + highscore + " guesses.");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                         

                
            }
        }
    }
}
