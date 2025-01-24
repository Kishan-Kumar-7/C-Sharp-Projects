using BlackJack;
namespace BlackJack
{
    class Program
    {

        static void Main()
        {
            BlackJackGame game = new BlackJackGame();
            game.Players = new List<string>() { "jessy", "Bob", "Mickel" };
            game.ListPlayer();

            //    Deck deck = new Deck();
            //    int timeSuffled = 0;
            //    deck = Shuffle(deck,out timeSuffled, 5);
            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " of " + card.Suit);
            //    }
            //    Console.WriteLine("The Deck Suffuled {0} Times.",timeSuffled);
            //}
            //public static Deck Shuffle(Deck deck, out int timeCount, int times = 1)
            //{
            //    timeCount = 0;
            //    for (int i = 0; i < times; i++)
            //    {
            //        timeCount++;
            //        List<Card> TempList = new List<Card>();
            //        Random random = new Random();
            //        while (deck.Cards.Count > 0)
            //        {
            //            int randomIndex = random.Next(0, deck.Cards.Count);
            //            TempList.Add(deck.Cards[randomIndex]);
            //            deck.Cards.RemoveAt(randomIndex);
            //        }
            //        deck.Cards = TempList;
            //    }
            //    return deck;
            //}
        }
    }
}