using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BlackJack
{
    public class BlackJackDealer: Dealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
