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

        public void shuffleDeck(Deck deck)
        {
            deck.shuffle();
        }

        public void uitdelen(Deck deck, Hand hand)
        {
            Card card = deck.kaartTrekken();
            hand.addCard(card);
            card = deck.kaartTrekken();
            hand.addCard(card);
        }

        public void hit(Deck deck, Hand hand)
        {
            Card card = deck.kaartTrekken();
            hand.addCard(card);
        }

        public void stand()
        {
            hand.toStand();
        }

        public int checkScore(Hand hand)
        {
            hand.checkScore();
            return hand.getScore();
        }

        public bool checkBlackjack(Hand hand)
        {
            hand.checkScore();
            hand.checkBlackjack();
            return hand.getBlackjack();
        }

        public bool checkBust(Hand hand)
        {
            hand.checkScore();
            hand.checkBust();
            return hand.getBust();
        }

        public bool checkWin(Hand hand)
        {
            hand.checkScore();
            hand.checkWon();
            return hand.getWon();
        }

        public Hand GetHand() { return hand; }
    }
}
