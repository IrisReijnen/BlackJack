using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        private int aantalKaarten = 52;
        private List<Card> cards;

        public Deck()
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            string[] suits = { "Harten", "Ruiten", "Klaveren", "Schoppen" };
            cards = new List<Card>();
            for (int i = 0; i < suits.Length; i++) 
            {
                for (int j = 0; j < ranks.Length; j++)
                {

                }
            }
        }

        public void schudden()
        {

        }

        public void uitdelen()
        {

        }
    }
}
