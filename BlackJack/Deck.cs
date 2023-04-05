using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            string[] suits = { "Harten", "Ruiten", "Klaveren", "Schoppen" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            
            cards = new List<Card>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(rank, suit));
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
