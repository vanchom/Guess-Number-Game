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

            Console.WriteLine("Please guess the number");
            string answer = Console.ReadLine();
            Int32.TryParse(answer, out result);
            return result;

        }
        static void Main(string[] args)
        {
            const int OurNumber = 10;
            int guessNumber = 0;

            for (int n = 20; n > 0; n--)
            {
                guessNumber = Getguess();
                switch (guessNumber) {
                    case (OurNumber):
                        Tool.ColorFulWriteLine("You are correct!! Well Done!!", ConsoleColor.Green);
                        //Console.WriteLine("you are correct!! Well Done!!");
                        n=0;
                        break;
                    case (1):
                        Tool.ColorFulWriteLine("It's too low", ConsoleColor.Blue);
                        break;
                    case (100):
                        Tool.ColorFulWriteLine("It's too high", ConsoleColor.Red);
                        break;
                    default:
                        if (guessNumber < OurNumber)
                        {
                            Tool.ColorFulWriteLine("Your number is too low", ConsoleColor.Yellow);
                        }
                        else if (guessNumber > OurNumber)
                        {
                            Tool.ColorFulWriteLine("Your number is too high",ConsoleColor.Magenta);
                        }
                        break;
                }
            }
               
                Console.ReadLine();

        }
    }
}
