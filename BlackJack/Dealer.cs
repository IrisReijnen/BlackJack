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

        public void handout(Deck deck, Hand hand)
        {
            Card card = deck.kaartTrekken();
            hand.addCard(card);
            card = deck.kaartTrekken();
            hand.addCard(card);
        }

        public void hideCard() 
        {
            List<Card> cards = hand.getCards();
            Card card = cards[0];
            card.changeIsHidden();
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

        public bool changeBlackjack(Hand hand)
        {
            hand.checkScore();
            return hand.checkBlackjack();
        }

        public bool changeBust(Hand hand)
        {
            hand.checkScore();
            return hand.changeBust();
        }

        public void changeWin(Hand hand)
        {
            hand.checkScore();
            hand.checkWon();
        }

        public Hand GetHand() { return hand; }
    }
}
