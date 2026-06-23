using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ClownsConsole
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave
        {
            get
            {
                return "big shoes";
            }
        }

        public void Honk()
        {
            Console.WriteLine("honk!!");
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"Name: {Name}, Height: {Height}");
        }
    }
}
