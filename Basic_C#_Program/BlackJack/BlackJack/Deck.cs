﻿using System;
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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades"};
            List<String> Faces = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            foreach (string face in Faces) {
                foreach (string suit in Suits) { 
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
