using BlackJack;
namespace BlackJack
{
    class Program
    {

        static void Main()
        {
            
            Deck deck = new Deck();
            int timeSuffled = 0;
            deck = Deck.Shuffle(deck, out timeSuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine("The Deck Suffuled {0} Times.", timeSuffled);
        }
    }
}