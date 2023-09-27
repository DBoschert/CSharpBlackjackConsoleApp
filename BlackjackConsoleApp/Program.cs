
using BlackjackConsoleApp;
using BlackjackConsoleApp.Models;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

const string baseurl = "http://localhost:8080";
HttpClient http = new HttpClient();

JsonSerializerOptions joptions = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};
Player? player = await LoginPrompt();
JsonResponse jsonResponse;



// The problem atm is that when you put in a username and password that isn't
// in the database the code runs into an error because it only checks if the player is nu
// it needs to check if the player is in the database
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



// Must give every variable a value or will become blank and unusable
var p1 = new Player()
{
    Id = player.Id,
    FirstName = player.FirstName,
    LastName = player.LastName,
    Username = player.Username,
    Password = player.Password,
    Wallet = 1800,
    Winnings = 700

};

await PlayerController.UpdatePlayer(p1, joptions);
