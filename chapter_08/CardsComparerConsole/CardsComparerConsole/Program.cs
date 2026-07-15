using CardsComparerConsole;
using CardsConsole;

Random random = new Random();

Card RandomCard()
{
    return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
}

void PrintCards(List<Card> cards)
{
    foreach (Card card in cards)
    {
        Console.WriteLine(card.Name);
    }
}

List<Card> cards = new List<Card>();
Console.Write("Enter number of cards: ");
if (int.TryParse(Console.ReadLine(), out int numberOfCards))
    for (int i = 0; i < numberOfCards; i++)
        cards.Add(RandomCard());

PrintCards(cards);

cards.Sort(new CardComparerByValue());
Console.WriteLine("\n... sorting the cards ...\n");

PrintCards(cards);