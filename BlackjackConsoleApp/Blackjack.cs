using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            Header(player);
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
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }
            }
            return input;
        }

        public static async Task<Player> Deposit(Player player)
        {
            string? input;
            bool looper = true;
            while (looper == true)
            {
                Header(player);
                Console.Write("Deposit Amount: ");
                input = Console.ReadLine();
                decimal nbr;
                bool success = decimal.TryParse(input, out nbr);

                if (success == true)
                {
                    player.Wallet += nbr;
                    await PlayerController.UpdatePlayer(player);
                    looper = false;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }
            }
            Header(player);
            return player;
        }

        private static void Header(Player player)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {player.FirstName} {player.LastName}");
            Console.WriteLine($"Wallet: {player.Wallet:c}");
        }

        public static async Task<Player> Game(Player player)
        {
            Shoe shoe = new Shoe();




            return player;
        }

    }
}
    

