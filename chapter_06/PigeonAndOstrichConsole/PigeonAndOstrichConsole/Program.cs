using PigeonAndOstrichConsole;

while (true)
{
    Bird bird;
    Console.Write("\nPress P for pigeon, O for ostrich: ");
    char key = Char.ToUpper(Console.ReadKey().KeyChar);

    switch(key)
    {
        case 'P':
            bird = new Pigeon();
            break;
        case 'O':
            bird = new Ostrich();
            break;
        default:
            return;
    }

    Console.Write("\nHow many eggs should it lay? ");
    if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
    Egg[] eggs = bird.LayEggs(numberOfEggs);
    foreach (Egg egg in eggs)
    {
        Console.WriteLine(egg.Description
            );
    }
}
