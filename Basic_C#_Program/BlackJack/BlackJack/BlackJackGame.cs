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
