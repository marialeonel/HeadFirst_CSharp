namespace ElephantExercise
{
    public class Elephant
    {
        public string Name;
        public int EarSize;

        public string WhoAmI()
        {
            return $"I am an elephant 🐘! My name is {Name} and my ears are {EarSize} inches tall.\n";
        }

        public void HearMessage(string message,Elephant whoSaidThat)
        {
            Console.WriteLine(Name  + " heard a message");
            Console.WriteLine($"{whoSaidThat.Name} said this: {message}");
        }

         public void SpeakTo(string message, Elephant whoToSpeakTo)
        {
            whoToSpeakTo.HearMessage(message, this);
        }
 
    }
}
