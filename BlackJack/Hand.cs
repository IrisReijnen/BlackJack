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
            foreach (Card card in cards)
            {
                if (card.getRank() == "ace" && score > 21)
                {
                    Console.WriteLine("The score is " + score + " but they have an ace. Ace changes from 11 to 1.");
                    card.changeValue();
                    score = 0;
                    foreach (Card card1 in cards)
                    {
                        score += card1.getValue();
                    }
                }
            }
            
        }

        public bool checkBlackjack()
        {
            if (cards.Count == 2 && score == 21)
            {
                blackjack = true;
                return true;
            }
            else
            {
                Console.WriteLine("Wrong! It's not blackjack.");
                return false;
            }
        }

        public bool changeBust()
        {
            if (score > 21)
            {
                bust = true;
                return true;
            } 
            else
            {
                Console.WriteLine("Wrong! Score is not above 21.");
                return false;
            }
        }

        public void checkWon()
        {
            if (score <= 21)
            {
                won = true;
            }
            else
            {
                Console.WriteLine("Wrong! To bad.");
            }
        }

        public void toStand() 
        { 
            stand = true; 
        }

        public void printCards()
        {
            foreach (Card card in cards)
            {
                if (card.getIsHidden())
                {
                    Console.WriteLine("? ?");
                }
                else
                {
                    Console.WriteLine(card.getSuit() + " " + card.getRank());
                }
                
            }
        }

        public int getScore() { return score; }

        public bool getBlackjack() { return blackjack; }

        public bool getBust() { return bust; }

        public bool getWon() { return won; }

        public bool getStand() { return stand; }

        public List<Card> getCards() { return cards; }
    }
}
