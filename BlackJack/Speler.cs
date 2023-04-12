using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Speler
    {
        private List<Hand> hands;
        //private int chips;

        public Speler()
        {
            hands = new List<Hand>();
            hands.Add(new Hand());
        }
    }
}
