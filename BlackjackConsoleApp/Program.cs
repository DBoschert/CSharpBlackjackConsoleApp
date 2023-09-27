using BlackjackConsoleApp;

Player? player = await Blackjack.LoginPrompt();

bool looper = true;

while (looper == true)
{
    switch (Blackjack.MainMenu())
    {
        case "1":
            bool loop1 = true;
            while (loop1 == true)
            {
                await Blackjack.Game(player);
                JsonResponse updatedPlayer = await PlayerController.PlayerLoginAsync(player.Username, player.Password);
                player = updatedPlayer.DataReturned as Player;
                bool loop2 = true;
                while (loop2 == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to play another round?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.Write("Please select a number: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            loop2 = false;
                            break;
                        case "2":
                            loop1 = false;
                            loop2 = false;
                            break;
                        default:
                            Console.WriteLine("INVALID INPUT");
                            break;
                    }
                }
            }
            break;
        case "2":
            player = await Blackjack.Deposit(player);
            break;
        case "3":
            looper = false;
            break;
    }
}