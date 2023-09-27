using System;
namespace BlackjackConsoleApp
{
	public class Shoe
	{
		public Stack<Card> ShoeOfCards { get; set; }

		public int ReshuffleAtSize { get; set; }

		public Shoe()
		{
			ShoeOfCards = new Stack<Card>();

            List<Card> unshuffledShoe = new List<Card>();

            for (int i = 1; i <= 6; i++)
            {
                Deck deck = new Deck();

                foreach (Card card in deck.DeckOfCards)
                {
                    unshuffledShoe.Add(card);
                }
            }

            Random random = new Random();

            while (unshuffledShoe.Count > 0)
            {
                int randomIndex = random.Next(0, unshuffledShoe.Count);
                ShoeOfCards.Push(unshuffledShoe.ElementAt(randomIndex));
                unshuffledShoe.RemoveAt(randomIndex);
            }

            ReshuffleAtSize = random.Next(60, 76);
		}
	}
}

