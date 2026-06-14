using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrichConsole
{
    public class Bird
    {
        public static Random Random = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called!");
            return new Egg[0];
        }
    }
}
