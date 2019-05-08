// Name: Luis Souza
// Date: 2019-04-16
// Guessing Game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string input = string.Empty;

            do
            {
                UInt32 secretNumber = game.DisplayMenu(); // sets the value to this variable with the returned value of the funtion DisplayMenu in class Game set to game before.
                if (secretNumber == 0) // case returned value is 0, then quits
                {
                    break;
                }

                game.PlayGame(secretNumber); // starts playing the game calling function PlayGame in class Game, with argument received from DisplayMenu.

                Console.Clear();
                // Writes the secret number and # of attempts, after finding out the number
                Console.WriteLine();
                Console.WriteLine("\tCongratulations! You GUESSED THE NUMBER: " + secretNumber);
                Console.WriteLine("\tAfter just " + game.guessCount + " attempts...");
                Console.WriteLine();

                Console.Write("\tPlay again? (press n/N to quit): ");
                input = Console.ReadLine();
                if (input == "n" || input == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("\tThanks for playing with us. See you soon!");
                    // If user type N/n to stop playing, then restore old screen colours and set a timer of 3 secs to quit
                    Console.ForegroundColor = game.currentTextColor;
                    Console.BackgroundColor = game.currentBackColor;
                    System.Threading.Thread.Sleep(3000);
                    break;
                }

            } while (true);
        }
    }
}

// Brief comments:
// Every challenge is very interesting to find out our capabilities.
// I loved to learn C# and all basic funtions. I'm gonna learn more
// to make better apps with this.