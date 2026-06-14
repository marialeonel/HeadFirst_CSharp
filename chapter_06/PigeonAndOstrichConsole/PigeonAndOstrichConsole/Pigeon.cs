using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrichConsole
{
    public class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for ( int number = 0; number < numberOfEggs; number++)
            {
                if (Bird.Random.Next(4) == 0)
                    eggs[number] = new BrokenEgg(Bird.Random.NextDouble() * 2 + 1, "white");
                else
                    eggs[number] = new Egg(Bird.Random.NextDouble() * 2 + 1, "white");
            }

            return eggs;
        }
    }
}
