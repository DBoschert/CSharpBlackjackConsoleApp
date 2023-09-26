using System;
namespace BlackjackConsoleApp
{
	public class Card
	{
		public string Rank { get; set; } = string.Empty;

		public string Suit { get; set; } = string.Empty;

		public int Value { get; set; }

		public void Print()
		{
			Console.WriteLine($"{Rank} of {Suit}");
		}

		public Card(string rank, string suit, int value)
		{
            Rank = rank;
            Suit = suit;
            Value = value;
        }
	}
}

