
using System;

namespace GuessNumber { 
    static class Tool
    {
        public static void ColorFulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
