using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrichConsole
{
    public class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int number = 0; number < numberOfEggs; number++)
            {
                double size = random.NextDouble() + 12;
                string color = "speckled";
                eggs[number] = new Egg(size, color);
            }

            return eggs;
        }
    }
}
