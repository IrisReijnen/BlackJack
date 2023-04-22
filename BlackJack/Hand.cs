using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Hand
    {
        private List<Card> cards;
        private int score;
        private bool won = false;
        private bool bust = false;
        private bool blackjack = false;
        private bool stand = false;

        public Hand() 
        {
            cards = new List<Card>();
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public void checkScore()
        {
            score = 0;
            foreach (Card card in cards)
            {
                score += card.getValue();
            }
        }

        public void checkBlackjack()
        {
            if (cards.Count == 2 && score == 21)
            {
                blackjack = true;
            }
        }

        public void checkBust()
        {
            if (score > 21)
            {
                bust = true;
            }
        }

        public void checkWon()
        {
            if (score <= 21)
            {
                won = true;
            }
        }

        public void toStand() 
        { 
            stand = true; 
        }

        public int getScore() { return score; }

        public bool getBlackjack() { return blackjack; }

        public bool getBust() { return bust; }

        public bool getWon() { return won; }

        public bool getStand() { return stand; }
    }
}
