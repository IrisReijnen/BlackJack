using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Dealer
    {
        private Hand hand;

        public Dealer()
        {
            hand = new Hand();
        }

        public void shuffle(Deck deck)
        {
            deck.shuffle();
        }

        public void uitdelen(Deck deck, Hand hand)
        {
            Card card = deck.kaartTrekken();
            hand.addCard(card);
        }
    }
}
