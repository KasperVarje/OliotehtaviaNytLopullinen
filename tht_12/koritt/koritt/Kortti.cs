using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koritt
{
    internal class Kortti
    {


    }
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
    }

    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck()
        {
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            Cards = new List<Card>();

            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card { Suit = suit, Rank = rank };
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }
    }
}
