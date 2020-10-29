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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you are correct!! Well Done!!");
                        n=0;
                        break;
                    case (1):
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("It's too low");
                        break;
                    case (100):
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It is too high");
                        break;
                    default:
                        if (guessNumber < OurNumber)
                        {
                            Console.WriteLine("Your number is too low");
                        }
                        else if (guessNumber > OurNumber)
                        {
                            Console.WriteLine("Your number is too high");
                        }
                        break;
                }
            }
               
                Console.ReadLine();

        }
    }
}
