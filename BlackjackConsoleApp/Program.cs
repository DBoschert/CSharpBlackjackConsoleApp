using BlackjackConsoleApp;

Player? player = await Blackjack.LoginPrompt();

bool looper = true;

while (looper == true)
{
    switch (Blackjack.MainMenu())
    {
        case "1":
            //play game
            break;
        case "2":
            player = await Blackjack.Deposit(player);
            break;
        case "3":
            looper = false;
            break;
    }
}