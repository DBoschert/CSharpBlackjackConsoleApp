using System;
namespace BlackjackConsoleApp
{
	public class Deck
	{
		public List<Card> DeckOfCards { get; set; }

		public Deck()
		{
			DeckOfCards = new List<Card>();

            Card aceOfSpades = new Card("Ace", "Spades", 11);
            Card twoOfSpades = new Card("2", "Spades", 2);
            Card threeOfSpades = new Card("3", "Spades", 3);
            Card fourOfSpades = new Card("4", "Spades", 4);
            Card fiveOfSpades = new Card("5", "Spades", 5);
            Card sixOfSpades = new Card("6", "Spades", 6);
            Card sevenOfSpades = new Card("7", "Spades", 7);
            Card eightOfSpades = new Card("8", "Spades", 8);
            Card nineOfSpades = new Card("9", "Spades", 9);
            Card tenOfSpades = new Card("10", "Spades", 10);
            Card jackOfSpades = new Card("Jack", "Spades", 10);
            Card queenOfSpades = new Card("Queen", "Spades", 10);
            Card kingOfSpades = new Card("King", "Spades", 10);

            Card aceOfClubs = new Card("Ace", "Clubs", 11);
            Card twoOfClubs = new Card("2", "Clubs", 2);
            Card threeOfClubs = new Card("3", "Clubs", 3);
            Card fourOfClubs = new Card("4", "Clubs", 4);
            Card fiveOfClubs = new Card("5", "Clubs", 5);
            Card sixOfClubs = new Card("6", "Clubs", 6);
            Card sevenOfClubs = new Card("7", "Clubs", 7);
            Card eightOfClubs = new Card("8", "Clubs", 8);
            Card nineOfClubs = new Card("9", "Clubs", 9);
            Card tenOfClubs = new Card("10", "Clubs", 10);
            Card jackOfClubs = new Card("Jack", "Clubs", 10);
            Card queenOfClubs = new Card("Queen", "Clubs", 10);
            Card kingOfClubs = new Card("King", "Clubs", 10);

            Card aceOfHearts = new Card("Ace", "Hearts", 11);
            Card twoOfHearts = new Card("2", "Hearts", 2);
            Card threeOfHearts = new Card("3", "Hearts", 3);
            Card fourOfHearts = new Card("4", "Hearts", 4);
            Card fiveOfHearts = new Card("5", "Hearts", 5);
            Card sixOfHearts = new Card("6", "Hearts", 6);
            Card sevenOfHearts = new Card("7", "Hearts", 7);
            Card eightOfHearts = new Card("8", "Hearts", 8);
            Card nineOfHearts = new Card("9", "Hearts", 9);
            Card tenOfHearts = new Card("10", "Hearts", 10);
            Card jackOfHearts = new Card("Jack", "Hearts", 10);
            Card queenOfHearts = new Card("Queen", "Hearts", 10);
            Card kingOfHearts = new Card("King", "Hearts", 10);

            Card aceOfDiamonds = new Card("Ace", "Diamonds", 11);
            Card twoOfDiamonds = new Card("2", "Diamonds", 2);
            Card threeOfDiamonds = new Card("3", "Diamonds", 3);
            Card fourOfDiamonds = new Card("4", "Diamonds", 4);
            Card fiveOfDiamonds = new Card("5", "Diamonds", 5);
            Card sixOfDiamonds = new Card("6", "Diamonds", 6);
            Card sevenOfDiamonds = new Card("7", "Diamonds", 7);
            Card eightOfDiamonds = new Card("8", "Diamonds", 8);
            Card nineOfDiamonds = new Card("9", "Diamonds", 9);
            Card tenOfDiamonds = new Card("10", "Diamonds", 10);
            Card jackOfDiamonds = new Card("Jack", "Diamonds", 10);
            Card queenOfDiamonds = new Card("Queen", "Diamonds", 10);
            Card kingOfDiamonds = new Card("King", "Diamonds", 10);

            DeckOfCards.Add(aceOfSpades);
            DeckOfCards.Add(twoOfSpades);
            DeckOfCards.Add(threeOfSpades);
            DeckOfCards.Add(fourOfSpades);
            DeckOfCards.Add(fiveOfSpades);
            DeckOfCards.Add(sixOfSpades);
            DeckOfCards.Add(sevenOfSpades);
            DeckOfCards.Add(eightOfSpades);
            DeckOfCards.Add(nineOfSpades);
            DeckOfCards.Add(tenOfSpades);
            DeckOfCards.Add(jackOfSpades);
            DeckOfCards.Add(queenOfSpades);
            DeckOfCards.Add(kingOfSpades);

            DeckOfCards.Add(aceOfClubs);
            DeckOfCards.Add(twoOfClubs);
            DeckOfCards.Add(threeOfClubs);
            DeckOfCards.Add(fourOfClubs);
            DeckOfCards.Add(fiveOfClubs);
            DeckOfCards.Add(sixOfClubs);
            DeckOfCards.Add(sevenOfClubs);
            DeckOfCards.Add(eightOfClubs);
            DeckOfCards.Add(nineOfClubs);
            DeckOfCards.Add(tenOfClubs);
            DeckOfCards.Add(jackOfClubs);
            DeckOfCards.Add(queenOfClubs);
            DeckOfCards.Add(kingOfClubs);

            DeckOfCards.Add(aceOfHearts);
            DeckOfCards.Add(twoOfHearts);
            DeckOfCards.Add(threeOfHearts);
            DeckOfCards.Add(fourOfHearts);
            DeckOfCards.Add(fiveOfHearts);
            DeckOfCards.Add(sixOfHearts);
            DeckOfCards.Add(sevenOfHearts);
            DeckOfCards.Add(eightOfHearts);
            DeckOfCards.Add(nineOfHearts);
            DeckOfCards.Add(tenOfHearts);
            DeckOfCards.Add(jackOfHearts);
            DeckOfCards.Add(queenOfHearts);
            DeckOfCards.Add(kingOfHearts);

            DeckOfCards.Add(aceOfDiamonds);
            DeckOfCards.Add(twoOfDiamonds);
            DeckOfCards.Add(threeOfDiamonds);
            DeckOfCards.Add(fourOfDiamonds);
            DeckOfCards.Add(fiveOfDiamonds);
            DeckOfCards.Add(sixOfDiamonds);
            DeckOfCards.Add(sevenOfDiamonds);
            DeckOfCards.Add(eightOfDiamonds);
            DeckOfCards.Add(nineOfDiamonds);
            DeckOfCards.Add(tenOfDiamonds);
            DeckOfCards.Add(jackOfDiamonds);
            DeckOfCards.Add(queenOfDiamonds);
            DeckOfCards.Add(kingOfDiamonds);
        }
	}
}

