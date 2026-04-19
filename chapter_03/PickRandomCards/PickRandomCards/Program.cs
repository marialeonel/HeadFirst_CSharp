using PickRandomCards;

Console.WriteLine("Enter the number of cards to pick: ");
string line = Console.ReadLine();

if(int.TryParse(line, out int numberOfCards)) {
    foreach (string card in CardPicker.PickSomeCards(numberOfCards)) {
        Console.WriteLine(card);
    }
} else {
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
