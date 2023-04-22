namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Dealer dealer = new Dealer();
            List<Speler> spelers = new List<Speler>();
            
            int aantalSpelers = 0;
            for (int i = 0; i < aantalSpelers; i++)
            {
                spelers.Add(new Speler());
            }

            dealer.shuffleDeck(deck);

            foreach (Speler speler in spelers)
            {
                List<Hand> hands = speler.GetHands();
                foreach (Hand hand in hands)
                {
                    dealer.uitdelen(deck, hand);
                    // print
                    while (hand.getStand())
                    {
                        Console.WriteLine("Do you wish to hit or stand?");
                        String action = Console.ReadLine();
                        if (action.ToLower() == "hit")
                        {
                            dealer.hit(deck, hand);
                        } else
                        {
                            speler.stand(hand);
                        }

                        // check score
                        Console.WriteLine("Dealer should check the score.");
                        dealer.checkScore(hand);
                    }
                }
            }
            Hand handDealer = dealer.GetHand();
            dealer.uitdelen(deck, handDealer);
            while (handDealer.getStand())
            {
                Console.WriteLine("Do you wish to hit or stand?");
                String action = Console.ReadLine();
                if (action.ToLower() == "hit")
                {
                    dealer.hit(deck, handDealer);
                }
                else
                {
                    dealer.stand();
                }
            }
        }
    }
}