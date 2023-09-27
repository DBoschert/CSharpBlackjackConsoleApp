using BlackjackConsoleApp;

Player? player = await Blackjack.LoginPrompt();


switch(Blackjack.MainMenu())
{
    case "1":
        //play game
        break;
    case "2":
        //deposit
        await Blackjack.Deposit(player);
        break;
    case "3":
        //exit
        break;
}

/*
var p1 = new Player()
{
    Id = player.Id,
    FirstName = player.FirstName,
    LastName = player.LastName,
    Username = player.Username,
    Password = player.Password,
    Wallet = 1900,
    Winnings = 700

};

await PlayerController.UpdatePlayer(p1);
*/