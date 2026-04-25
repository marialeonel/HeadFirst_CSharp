using ElephantExercise;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
Elephant lucynda = new Elephant() { Name = "Lucynda", EarSize = 33 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucynda, 3 to swap: ");
while(true)
{
    string userChoice = Console.ReadLine();

    if (int.TryParse(userChoice, out int result))
    {
        switch (result)
        {
            case 1:
                Console.WriteLine(lloyd.WhoAmI());
                break;
            case 2:
                Console.WriteLine(lucynda.WhoAmI());
                break;
            case 3:
                Elephant intermediary = lloyd;
                lloyd = lucynda;
                lucynda = intermediary;
                Console.WriteLine("References have been swapped!\n");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.\n");
    }
}

