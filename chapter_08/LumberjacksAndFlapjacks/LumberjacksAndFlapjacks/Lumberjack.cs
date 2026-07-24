using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjacksAndFlapjacks
{
    public class Lumberjack
    {
        public string Name { get; set; }
        private Stack<Flapjack> flapjacks = new();

        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapjacks(Flapjack flapjack)
        {
            flapjacks.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjacks.Count > 0)
            {
                Console.WriteLine(
                    $"{Name} ate a {flapjacks.Pop().ToString().ToLower()} flapjack");
            
            }
        }
    }
}
