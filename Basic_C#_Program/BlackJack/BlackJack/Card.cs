﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit { 
    Club,
    Diamond,
    Heart,
    Spades
    }
    public enum Face { 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
