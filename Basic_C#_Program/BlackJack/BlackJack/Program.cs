using BlackJack;
namespace BlackJack
{
    class Program
    {

        static void Main()
        {
            Game game = new BlackJackGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player;
            game = game - player;


            Deck deck = new Deck();
            int timeSuffled = 0;
            deck = Deck.Shuffle(deck, out timeSuffled, 5);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine("The Deck Suffuled {0} Times.", timeSuffled);
        }
    }
}