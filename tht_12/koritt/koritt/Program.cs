using koritt;

internal class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new Deck();
        deck.Shuffle();

        Console.WriteLine("Shuffled Deck:");
        foreach (Card card in deck.Cards)
        {
            Console.WriteLine(card.Rank + " of " + card.Suit);
        }   
    }
}