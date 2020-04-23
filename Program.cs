using System.Data;
using System.Linq.Expressions;
using System;

namespace Gaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 8;
            int guessCount = 0;
            int guess = 0;
            string choice = "";
            bool outOfGuesses = false;
            
            Console.WriteLine("Number Guessing Game!");

            while (!outOfGuesses)
            {
                Console.Write("Enter guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess!= secretNumber && !outOfGuesses)
                {
                    Console.Write("There are 3 levels; 'Easy', 'Medium', and 'Hare'. Make a choice: ");
                    choice = Console.ReadLine();
                    if (choice == "Easy")
                    {
                        Console.WriteLine("You get to pick a number from 1 to 10 and you have 6 guesses.");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        int guessLimit = 6;
                        guessCount++;
                        if (guess != secretNumber && guessCount < guessLimit)
                        {
                            Console.WriteLine("That was wrong!");
                        }

                    else if (choice == "Medium")
                    {
                        Console.WriteLine("You get to pick a number from 1 to 20 and you have 4 guesses.");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        guessLimit = 4;
                        guessCount++;
                        if (guess != secretNumber && guessCount < guessLimit)
                        {
                            Console.WriteLine("That was wrong!");
                        }
                    else if (choice == "Hard")
                    {
                        Console.WriteLine("You get to pick a number from 1 to 20 and you have 4 guesses.");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        guessLimit = 3;
                        guessCount++;
                        if (guess != secretNumber && guessCount < guessLimit)
                        {
                             Console.WriteLine("That was wrong!");
                        }

                    }
                    else if (outOfGuesses)
                    {
                        outOfGuesses = true;
                        Console.WriteLine("Game Over.");
                    }
                else if (guess == secretNumber)
                {
                    Console.WriteLine("You are right");
                }

                    }
                    }

                }
            }
        }
                
                
}
            
            
                
    }
    
