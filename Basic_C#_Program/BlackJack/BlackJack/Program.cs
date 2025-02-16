using BlackJack;
namespace BlackJack
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Welcome to the Games of Cards Casino. \nLet's Start by Sharing Your Name With Us :");
            string playerName = Console.ReadLine();
            Console.WriteLine("And How Much Money Did You Going To Play With Today?");
            int pBank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would You Like To Join A Game Of BlackJack Right Now?", playerName);
            string pAnswer = Console.ReadLine().ToLower();
            if (pAnswer == "yes" || pAnswer == "yea" || pAnswer == "y" || pAnswer == "ya") { 
                Player player = new Player(playerName, pBank);
                Game game = new BlackJackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0) 
                {
                    game.Play();
                }
                if (player.Balance <= 0)
                {
                    Console.WriteLine("Sorry! You Do Not Have Sufficiant Balance To Play Further..\nPlease Visit Again...");
                    game -= player;
                }
                else 
                {
                    game -= player;
                    Console.WriteLine("Thank You For Playing!");
                }
            }
            Console.WriteLine("Feel Free to Look Around Casino. Bye For Now.");
        }
    }
}