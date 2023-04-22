namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Dealer dealer = new Dealer();
            List<Speler> spelers = new List<Speler>();

            
            int aantalSpelers;
            while (true)
            {
                Console.WriteLine("How many players? 1-4");
                String number = Console.ReadLine();
                if (number == "1" || number == "2" || number == "3" || number == "4")
                {
                    aantalSpelers = Convert.ToInt32(number);
                    break;
                } 
                else
                {
                    Console.WriteLine("1-4");
                }
            }
            
            for (int i = 0; i < aantalSpelers; i++)
            {
                spelers.Add(new Speler());
            }

            dealer.shuffleDeck(deck);

            int spelerNr = 0;
            foreach (Speler speler in spelers)
            {
                spelerNr++;
                Console.WriteLine();
                Console.WriteLine("Speler" +  spelerNr);

                List<Hand> hands = speler.GetHands();
                foreach (Hand hand in hands)
                {
                    dealer.handout(deck, hand);
                    hand.printCards();
                    Console.WriteLine();
                    while (!hand.getStand())
                    {
                        Console.WriteLine("Do you wish to hit or stand?");
                        String action = Console.ReadLine();
                        if (action.ToLower() == "hit")
                        {
                            dealer.hit(deck, hand);
                            hand.printCards();
                        }
                        else
                        {
                            speler.stand(hand);
                        }

                        // Check score
                        while (true)
                        {
                            Console.WriteLine("Dealer should check their score.");
                            Console.WriteLine("Check score");
                            action = Console.ReadLine();
                            if (action.ToLower() == "check score")
                            {
                                Console.WriteLine(dealer.checkScore(hand));
                                break;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Blackjack");
                        Console.WriteLine("Bust");
                        Console.WriteLine("Nothing");

                        action = Console.ReadLine();
                        if (action.ToLower() == "bust")
                        {
                            if (dealer.changeBust(hand))
                            {
                                break;
                            }

                        }
                        else if (action.ToLower() == "blackjack")
                        {
                            if (dealer.changeBlackjack(hand))
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dealer");

            Hand handDealer = dealer.GetHand();
            dealer.handout(deck, handDealer);
            dealer.hideCard();
            handDealer.printCards();
            while (!handDealer.getStand())
            {
                Console.WriteLine("Do you wish to hit or stand?");
                String action = Console.ReadLine();
                if (action.ToLower() == "hit")
                {
                    dealer.hit(deck, handDealer);
                    handDealer.printCards();
                    Console.WriteLine();
                }
                else
                {
                    dealer.stand();
                }

                // Check score
                while (true)
                {
                    Console.WriteLine("Dealer should check their score.");
                    Console.WriteLine("Check score");
                    action = Console.ReadLine();
                    if (action.ToLower() == "check score")
                    {
                        Console.WriteLine(dealer.checkScore(handDealer));
                        break;
                    }
                }

                Console.WriteLine("Blackjack");
                Console.WriteLine("Bust");
                Console.WriteLine("Nothing");

                action = Console.ReadLine();
                if (action.ToLower() == "bust")
                {
                    if (dealer.changeBust(handDealer))
                    {
                        break;
                    }

                }
                else if (action.ToLower() == "blackjack")
                {
                    if (dealer.changeBlackjack(handDealer))
                    {
                        break;
                    }
                }
            }

            int dealerScore = dealer.checkScore(handDealer);

            spelerNr = 0;
            foreach (Speler speler in spelers)
            {
                spelerNr++;
                Console.WriteLine("Speler" + spelerNr);
                List<Hand> hands = speler.GetHands();
                foreach (Hand hand in hands)
                {
                    if (handDealer.getBust() && !hand.getBust())
                    {
                        dealer.changeWin(hand);
                        Console.WriteLine("You have Won");
                    }
                    else if (dealer.checkScore(hand) > dealerScore && !hand.getBust())
                    {
                        dealer.changeWin(hand);
                        Console.WriteLine("You have Won");
                    } 
                    else if (hand.getBlackjack() && !handDealer.getBlackjack())
                    {
                        dealer.changeWin(hand);
                        Console.WriteLine("You have Won");
                    }
                    else
                    {
                        Console.WriteLine("You have Lost");
                    }
                }
            }
        }
    }
}