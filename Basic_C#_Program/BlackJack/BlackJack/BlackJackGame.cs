using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public  class BlackJackGame : Game, IWalkAway
    {
        public BlackJackDealer Dealer { get; set; }
        public override void Play() 
        { 
            Dealer = new BlackJackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place Your Bet!");
            foreach (Player player in Players) 
            {
                int bet = Convert.ToInt32( Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) 
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players) 
                {
                    Console.Write("{0}.", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) 
                    {
                        
                    }
                }
            }
        }
        public override void ListPlayer()
        {
            Console.WriteLine("Welcome in BlackJack Game Players");
            base.ListPlayer();
        }
        public void WalkAway(Player player) { 
            throw new NotImplementedException();
        }
    }
}
