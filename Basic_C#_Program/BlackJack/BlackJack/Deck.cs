using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Deck() { 
            Cards = new List<Card>();
            for (int i = 0; i < 13; i++) {
                for (int j = 0; j < 4; j++) { 
                    Card card = new Card();
                    card.Suit = (Suit)j;
                    card.Face = (Face)i;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public static Deck Shuffle(Deck deck, out int timeCount, int times = 1)
        {
            timeCount = 0;
            for (int i = 0; i < times; i++)
            {
                timeCount++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

        internal static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
