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
        }
    }
}