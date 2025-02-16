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
            Dealer.Deck = Deck.Shuffle(Dealer.Deck);
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
                Console.WriteLine("Dealing...\n");
                foreach (Player player in Players) 
                {
                    Console.Write("{0} : ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) 
                    {
                        bool BlackJack = BlackJackRules.CheckForBlackJack(player.Hand);
                        if (BlackJack) 
                        { 
                            Console.WriteLine("BlackJack {0} Wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealing....\n");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool BlackJack = BlackJackRules.CheckForBlackJack(Dealer.Hand);
                    if (BlackJack) 
                    { 
                        Console.WriteLine("Dealer Has BlackJack Everyone Loses.... Try Next Time");
                        foreach (KeyValuePair<Player, int> entry in Bets) 
                        { 
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                { 
                    Console.WriteLine("Your Cards Are :");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit Or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    { 
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackJackRules.IsBusted(player.Hand);
                    if (busted) 
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You Loose Your Bet Of {1}. Your Balance Is Now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do You Wanna Play Aagin???");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "y" || answer == "yes")
                        {
                            player.IsActivelyPlaying = true;
                            return;
                        }
                        else
                        { 
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = BlackJackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.isBusted && !Dealer.Stay)
            {
                Console.WriteLine("Dealer Is Hitting....");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackJackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer Is Staying.....");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!!!");
                foreach (KeyValuePair<Player, int> entry in Bets) 
                {
                    Console.WriteLine("{0} Won {1}...", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name ).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            { 
                bool? playerWon = BlackJackRules.CompareHands(player.Hand,Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No One Wins...");
                }
                else if (playerWon == true)
                {
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                    Console.WriteLine("{0} Won {1} Money... Your Balance is {2}.", player.Name, Bets[player], player.Balance);
                }
                else
                {
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("Dealer Wins {0}! Your Balance is {1}.", Bets[player], player.Balance);
                }
                Console.WriteLine("Do You Want To Play Again???");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y" || answer == "ya") player.IsActivelyPlaying = true;
                else player.IsActivelyPlaying = false;
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
