using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsoleApp
{
    public class Blackjack
    {

        public static async Task<Player> LoginPrompt()
        {
            Player? player;
            while (true)
            {
                Console.Write("Enter Username: ");
                string? username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string? password = Console.ReadLine();
                JsonResponse jsonResponse = await PlayerController.PlayerLoginAsync(username!, password!);
                player = jsonResponse.DataReturned as Player;
                var status = jsonResponse.HttpStatusCode;
                if (player == null || status == 404)
                {
                    Console.WriteLine("\n[Login Failed!]");
                    Console.Write("[PRESS ENTER]");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                break;
            }
            Console.Clear();
            Console.WriteLine($"Welcome {player.FirstName} {player.LastName}");
            Console.WriteLine($"Wallet: {player.Wallet:c}");
            return player;
        }

        public static string? MainMenu()
        {
            string? input = "";
            bool looper = true;
            while (looper == true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Play Blackjack");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Exit");
                Console.Write("Please select a number: ");
                input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3")
                {
                    looper = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            return input;
        }

    }
}
