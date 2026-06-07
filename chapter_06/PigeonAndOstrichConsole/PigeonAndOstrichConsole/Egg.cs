using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrichConsole
{
    public class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }

        public Egg(double size, string color) {
            Size = size;
            Color = color;
        }

        public string Description {
            get { return $"This egg is {Size} cm in size and has a {Color} color."; }
        }
    }
}
