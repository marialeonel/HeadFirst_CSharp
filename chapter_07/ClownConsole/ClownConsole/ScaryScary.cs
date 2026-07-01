namespace ClownConsole
{
    public class ScaryScary : FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }
        private readonly int scaryThingCount = 0;
        public ScaryScary(string funny, int scaryCount) : base(funny)
        {
            scaryThingCount = scaryCount;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! GOTCHA!! Look at my {ScaryThingIHave}");
        }
    }
}
