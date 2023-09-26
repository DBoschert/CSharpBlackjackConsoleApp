using BlackjackConsoleApp;

JsonResponse res = await PlayerController.PlayerLoginAsync("je", "passw");
Player? player = res.DataReturned as Player;
Console.WriteLine(res.HttpStatusCode);


//Player? player = await LoginPrompt();
//JsonResponse jsonResponse;

// The problem atm is that when you put in a username and password that isn't
// in the database the code runs into an error because it only checks if the player is nu
// it needs to check if the player is in the database
/*
async Task<Player> LoginPrompt()
{
    while (true)
    {
            Console.Write("Enter Username: ");
            string? username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();
            jsonResponse = await PlayerController.PlayerLoginAsync(http, joptions, username!, password!);
            player = jsonResponse.DataReturned as Player;
            var status = jsonResponse.HttpStatusCode;
        Console.WriteLine($"status = {status}");
        if (player == null || status == 404) 
        {
            Console.WriteLine("\n[Login Failed!]");
            Console.Write("[PRESS ENTER]");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
        
        Console.WriteLine("GREAT");
        Console.WriteLine(player.LastName);
        break;
    }
    return player;
}
*/