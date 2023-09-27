using BlackjackConsoleApp;

Player? player = await Blackjack.LoginPrompt();

bool looper = true;

while (looper == true)
{
    switch (Blackjack.MainMenu())
    {
        case "1":
            player = await Blackjack.Game(player);
            break;
        case "2":
            player = await Blackjack.Deposit(player);
            break;
        case "3":
            looper = false;
            break;
    }
}