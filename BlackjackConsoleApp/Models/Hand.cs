using System;
using System.Text.Json.Serialization;

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
		[JsonIgnore]
		public DateTime DateTime { get; set; } = DateTime.Now;
		public virtual Player? Player { get; set; }

	}
}

