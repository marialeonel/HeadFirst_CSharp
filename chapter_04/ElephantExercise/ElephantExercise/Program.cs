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
            //case 4:
            //    lloyd = lucynda;
            //    lloyd.EarSize = 4321;
            //    lloyd.WhoAmI();
            //    break;
            /* apenas para teste do que acontece quando lloyd 
             * recebe a referência de lucynda e depois tem seu EarSize modificado.
             * O resultado é que tanto lloyd quanto lucynda terão o EarSize modificado, 
             * pois ambos apontam para o mesmo objeto na memória. 
             * Portanto, ao modificar o EarSize através de lloyd, 
             * você também estará modificando o EarSize do objeto referenciado por lucynda, 
             * já que ambos estão apontando para o mesmo objeto.*/
            case 5:
                lucynda.SpeakTo("Hi Lloyd, how are you?", lloyd);
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

