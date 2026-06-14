namespace PigeonAndOstrichConsole
{
    public class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color) : base(size, color)
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
