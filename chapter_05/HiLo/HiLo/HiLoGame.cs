using System;
using System.Collections.Generic;
using System.Text;

namespace HiLo
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        static Random random = new();
        static int currentNumber = random.Next(1, MAXIMUM + 1);
        static int pot = 10;

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && nextNumber > currentNumber) || (!higher && nextNumber < currentNumber))
            {
                Console.WriteLine($"You win!");
                pot++;
            }
            else
            {
                Console.WriteLine($"You lose!");
                pot--;
            }
            currentNumber = nextNumber;
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if(currentNumber <= half) Console.WriteLine($"The current number is at least {half}.");
            else
                Console.WriteLine($"The current number is at most {half}");
            pot--;
        }

        public static int GetPot()
        {
            return pot;
        }
    }
}
