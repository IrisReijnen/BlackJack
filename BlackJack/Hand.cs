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
        private bool heeftGewonnen = false;
        private bool isDood = false;
        private bool blackjack = false;

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

        

        public int getScore() { return score; }

        public bool getBlackjack() { return blackjack; }
    }
}
