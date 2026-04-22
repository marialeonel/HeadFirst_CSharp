using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Console.WriteLine($"Welcome to the casino. The odds are { odds }.");
            while(player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0) {
                        if (random.NextDouble() > odds)
                        {
                            Console.WriteLine($"You won {pot}!");
                            player.ReceiveCash(pot);
                        }
                        else
                        {
                            Console.WriteLine("You lost.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("You're broke :D thank youuuu");
        }
    }
}