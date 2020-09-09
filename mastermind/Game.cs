using System;
using System.Collections.Generic;
using System.Text;

namespace mastermind
{
    class Game
    {
        Code inGameCode = new Code();
        bool stop = false;
        Pin guesPosition1;
        Pin guesPosition2;
        Pin guesPosition3;
        Pin guesPosition4;
        bool guesInput = true;
        int correctPlaceColor = 0;
        int correctColor = 0;
        public List<Pin> answerList = new List<Pin>();
        string[] pinValues = { "a", "b", "c", "d", "e", "f" };
        bool correctShowResult = false;
         int guesses = 0;
        public int finalGuesses = 100;


        public void createGame()
        {

           

            while (stop == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to a new game.");
                Console.WriteLine("Which of the following options do you want to choose?");
                Console.WriteLine("g = make a guess");
                Console.WriteLine("q = stop the game");
                Console.WriteLine("s = show code");
                Console.WriteLine("");

                String input = Console.ReadLine();

                switch(input)
                {
                    case "g":

                      
                        while (guesInput == true)
                        {
                            Console.WriteLine("Put your guess for the first position (a, b, c, d, e, f).");
                            String inputPosition1 = Console.ReadLine();
                            string guesPosition1Input = CheckGuessInput(inputPosition1);
                            guesPosition1 = new Pin(guesPosition1Input, 0);
                            answerList.Add(guesPosition1);
                        }
                        guesInput = true;
                        while (guesInput == true)
                        {
                            Console.WriteLine("Put your guess for the second position (a, b, c, d, e, f).");
                            String inputPosition2 = Console.ReadLine();
                            string guesPosition2Input = CheckGuessInput(inputPosition2);
                            guesPosition2 = new Pin(guesPosition2Input, 1);
                            answerList.Add(guesPosition2);
                        }
                        guesInput = true;
                        while (guesInput == true)
                        {
                            Console.WriteLine("Put your guess for the third position (a, b, c, d, e, f).");
                            String inputPosition3 = Console.ReadLine();
                            string guesPosition3Input = CheckGuessInput(inputPosition3);
                            guesPosition3 = new Pin(guesPosition3Input, 2);
                            answerList.Add(guesPosition3);
                        }
                        guesInput = true;
                        while (guesInput == true)
                        {
                            Console.WriteLine("Put your guess for the fourth position (a, b, c, d, e, f).");
                            String inputPosition4 = Console.ReadLine();
                            string guesPosition4Input = CheckGuessInput(inputPosition4);
                            guesPosition4 = new Pin(guesPosition4Input, 3);
                            answerList.Add(guesPosition4);
                        }
                        guesInput = true;

                       foreach (Pin p in answerList)
                        {
                            foreach (Pin q in inGameCode.codeList)
                            {
                                if(p.Value==q.Value && p.Position == q.Position)
                                {
                                    correctPlaceColor = correctPlaceColor + 1;
                                }                               

                            }
                        }

                        foreach (string value in pinValues)
                        {
                            int answer = 0;
                            int code = 0;

                            foreach (Pin p in answerList) {
                                if (value == p.Value)
                                    answer = answer + 1;
                            }

                            foreach (Pin p in inGameCode.codeList)
                            {
                                if (value == p.Value)
                                    code = code + 1;
                            }

                            if(answer == code) //kan kleiner maar zekerheid??
                            {
                                correctColor = correctColor + answer;
                            }
                            else if( answer > code)
                            {
                                correctColor = correctColor + code;
                            }
                            else if( answer < code)
                            {
                                correctColor = correctColor + answer;
                            }
                        }

                        guesses = guesses + 1; 

                        if (correctPlaceColor == 4)
                        {
                            Console.WriteLine("Congratulations, you have 4 correctly placed in the correct color.");
                            Console.WriteLine("You have done this after " + guesses + " guesses.");
                            stop = true;
                            finalGuesses = guesses; 
                        }
                        else {
                            Console.WriteLine("Unfortanly that is incorrect.");
                            Console.WriteLine("You have " + correctPlaceColor + " correctly placed and in the correct color.");
                            Console.WriteLine("You have " + correctColor + " pins in the correct color.");
                        }

                        correctColor = 0;
                        correctPlaceColor = 0;
                        answerList.Clear();
                        break;
                    case "q":
                        Console.WriteLine("Game is stopped");
                        stop = true;
                        break;
                    case "s":
                        Console.WriteLine("Are you sure you want to see the code?(yes/no)");

                        while(correctShowResult == false)
                        {
                            string inputShowResult = Console.ReadLine();

                            if(inputShowResult== "yes" )
                            {
                                Console.WriteLine(inGameCode.codeList[0].Value);
                                Console.WriteLine(inGameCode.codeList[1].Value);
                                Console.WriteLine(inGameCode.codeList[2].Value);
                                Console.WriteLine(inGameCode.codeList[3].Value);
                                stop = true;
                                correctShowResult = true;
                            }
                            else if(inputShowResult == "no")
                            {
                                correctShowResult = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                        }


                        correctShowResult = false;

                        break;
                    default:
                        Console.WriteLine("Input is incorrect.");
                        break;
                }
            }
            
        }

        public string CheckGuessInput(string guessInput)
        {
            if(guessInput == "a" || guessInput == "b" || guessInput == "c" || guessInput == "d" || guessInput == "e" || guessInput == "f")
            {
            string guesPosition = guessInput;
                guesInput = false;
            return guesPosition;
            }
            else
            {
                Console.WriteLine("This input is incorrect");
                guesInput = true;
                string guesPosition = "";
                return guesPosition;
            }
            
            
        }

      
    }
}
