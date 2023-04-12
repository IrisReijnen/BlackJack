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

        public void shuffle()
        {
            Random random = new Random();
            int n = cards.Count;

            for (int i = cards.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Card value = cards[rnd];
                cards[rnd] = cards[i];
                cards[i] = value;
            }
        }

        public void uitdelen()
        {

        }

        public List<Card> getCards()
        {
            return cards;
        }
    }
}
