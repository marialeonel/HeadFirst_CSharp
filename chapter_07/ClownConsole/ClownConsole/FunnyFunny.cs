namespace ClownConsole
{
    public class FunnyFunny : IClown
    {
        public string FunnyThingIHave { get { return _funnyThingIHave; } }
        private readonly string _funnyThingIHave;

        public FunnyFunny(string funny)
        {
            _funnyThingIHave = funny;
        }
        public void Honk()
        {
            Console.WriteLine($"Hi kids, I have a {_funnyThingIHave}.");
        }
    }
}
