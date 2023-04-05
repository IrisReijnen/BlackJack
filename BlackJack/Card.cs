using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        private string rank;
        private string suit;
        private int value;
        private bool isOpen = true;

        public Card(string rank, string suit) 
        {
            this.rank = rank;
            this.suit = suit;
            switch (rank)
            {
                case "2":
                    value = 2; 
                    break;
                case "3": 
                    value = 3; 
                    break;
                case "4":
                    value = 4;
                    break;
                case "5":
                    value = 5;
                    break;
                case "6":
                    value = 6;
                    break;
                case "7":
                    value = 7;
                    break;
                case "8":
                    value = 8;
                    break;
                case "9":
                    value = 9;
                    break;
                case "10":
                case "jack":
                case "queen":
                case "king":
                    value = 10;
                    break;
                case "ace":
                    value = 11;
                    break;
            }
        }

        public void changeValue()
        {
            if (rank == "ace")
            {
                value = 1;
            }
        }

        public void changeIsOpen()
        {
            if (isOpen)
            {
                isOpen = false;
            } 
            else
            {
                isOpen = true;
            }
        }

        public string getRank() { return rank; }
        public string getSuit() {  return suit; }
        public int getValue() { return value; }
        public bool getIsOpen() { return isOpen; }
    }
}
