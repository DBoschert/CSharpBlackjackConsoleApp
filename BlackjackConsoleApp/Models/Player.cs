using System;
namespace BlackjackConsoleApp
{
	public class Player
	{
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public decimal Wallet { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Winnings { get; set; } 
    }
}

