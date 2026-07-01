using System;
using System.Collections.Generic;
using System.Text;

namespace ClownConsole
{
    public interface IClown
    {
        string FunnyThingIHave { get; }
        public static int CarCapacity { get { return _carCapacity; } set { if (value > 10) _carCapacity = value; } }
        private static int _carCapacity = 12;
        protected static Random random = new Random();
        void Honk();

        public static string ClownCardDescription()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }
    }
}
