using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static int Getguess()
        {
            int result = 0;

            string numberTries = "Please guess the number between 0 to 100";
            Console.WriteLine(numberTries);
            string answer = Console.ReadLine();
            Int32.TryParse(answer, out result);
            return result;

        }
        static void Main(string[] args)
        {
            const int OurNumber = 10;
            int guessNumber = 0;
            int tries = 0;
            int n = 5;

            for (n = 5; n > 0; n--)
            {
               
                guessNumber = Getguess();
                switch (guessNumber) {
                    case (OurNumber):
                        Tool.ColorFulWriteLine("You are correct!! Well Done!!", ConsoleColor.Green);
                        //Console.WriteLine("you are correct!! Well Done!!");
                        n=0;
                        tries += 1;
                        Tool.ColorFulWriteLine($"You have tried {tries} times", ConsoleColor.Green);
                        break;
                    case (1):
                        Tool.ColorFulWriteLine("It's too low", ConsoleColor.Blue);
                        tries += 1;
                        Console.WriteLine($"You have tried {tries} times");
                        Tool.ColorFulWriteLine($"You have {n-1} times to guess a number", ConsoleColor.Red);
                        break;
                    case (50):
                        Tool.ColorFulWriteLine("It's too high", ConsoleColor.White);
                        tries += 1;
                        Console.WriteLine($"You have tried {tries} times");
                        Tool.ColorFulWriteLine($"You have {n-1} times to guess a number", ConsoleColor.Red);
                        break;
                    default:
                        if (guessNumber < OurNumber)
                        {
                            Tool.ColorFulWriteLine("Your number is low", ConsoleColor.Yellow);
                            tries += 1;
                            Console.WriteLine($"You have tried {tries} times");
                            Tool.ColorFulWriteLine($"You have {n-1} times to guess a number", ConsoleColor.Red);
                        }
                        else if (guessNumber > OurNumber)
                        {
                            Tool.ColorFulWriteLine("Your number is high",ConsoleColor.Magenta);
                            tries += 1;
                            Console.WriteLine($"You have tried {tries} times");
                            Tool.ColorFulWriteLine($"You have {n-1} times to guess a number", ConsoleColor.Red);
                        }
                        break;
                }
            }
               
                Console.ReadLine();

        }
    }
}
