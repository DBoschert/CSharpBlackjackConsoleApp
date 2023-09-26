using System;
namespace BlackjackConsoleApp
{
	public class Hand
	{
		public int Id {  get; set; }
		public decimal InitialBet { get; set; }
		public int PlayerHandTotal { get; set; }
		public int DealerHandTotal { get; set; }
		public string WinLoss { get; set; } = string.Empty;
		public decimal AmountWon { get; set; } = 0;
		public int PlayerId { get; set; }
		public virtual Player? Player { get; set; }

	}
}

