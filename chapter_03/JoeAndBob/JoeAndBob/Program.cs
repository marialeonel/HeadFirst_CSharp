using System;

namespace JoeAndBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while(true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.WriteLine("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                if(int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should give the cash? (Joe or Bob)");
                    string witchGuy = Console.ReadLine();

                    if(witchGuy.ToLower() == "joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (witchGuy.ToLower() == "bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Invalid guy specified. Please enter Joe or Bob.");
                    }
                } else
                {
                    Console.WriteLine("Please, enter an amount or a blank line to exit." +
                        "");
                }

            }
        }
    }
}