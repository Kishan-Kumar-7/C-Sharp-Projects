﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.BlackJack
{
    public class BlackJackRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValue(List<Card> Hand) 
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++) 
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand) 
        {
            int[] possibleValuew = GetAllPossibleHandValue(Hand);
            int value = possibleValuew.Max();
            if(value == 21) return true;
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        { 
            int value = GetAllPossibleHandValue(Hand).Min();
            if(value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValue(Hand);
            foreach (int value in possibleHandValues)
            { 
                if (value > 16 && value < 22) return true;
            }
            return false;
        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> Dealerhand)
        {
            int[] playerResult = GetAllPossibleHandValue(PlayerHand);
            int[] DealerResult = GetAllPossibleHandValue(Dealerhand);

            int playerScore = playerResult.Where(x => x < 22).Max();
            int dealerScore = DealerResult.Where(x => x < 22).Max();
            if (playerScore > dealerScore) return true;
            else if(playerScore < dealerScore) return false;
            else return null;
        }
    }
}
