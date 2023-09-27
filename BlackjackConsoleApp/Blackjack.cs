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

        private static void Header(Player player, decimal bet)
        {
            Console.Clear();
            decimal displayWallet = player.Wallet - bet;
            Console.WriteLine($"Welcome {player.FirstName} {player.LastName}");
            Console.WriteLine($"Wallet: {displayWallet:c}");
        }

        public static async Task<Player> Game(Player player)
        {
            Header(player);

            Shoe shoe = new Shoe();

            bool looper = true;
            while (looper == true)
            {
                string? input;

                Console.Write("Initial Bet: ");
                input = Console.ReadLine();
                decimal nbr;
                bool success = decimal.TryParse(input, out nbr);
                if (success == false)
                {
                    Console.WriteLine("INVALID INPUT");
                    continue;
                }

                Hand hand = new Hand();
                hand.InitialBet = nbr;
                Header(player, hand.InitialBet);

                List<Card> playerCards = new List<Card>();
                List<Card> dealerCards = new List<Card>();

                playerCards.Add(shoe.ShoeOfCards.Pop());
                dealerCards.Add(shoe.ShoeOfCards.Pop());
                playerCards.Add(shoe.ShoeOfCards.Pop());
                dealerCards.Add(shoe.ShoeOfCards.Pop());

                DisplayCardsBeforeDealerHit(playerCards, dealerCards);

                int playerScore = CheckHand(playerCards);
                int dealerScore = CheckHand(dealerCards);
                // DEALER WIN
                if(dealerScore == 21 && playerScore != 21)
                {
                    Console.WriteLine("DEALER WINS");
                    hand.PlayerHandTotal = playerScore;
                    hand.DealerHandTotal = dealerScore;
                    hand.WinLoss = "LOSS";
                    hand.Player = player;
                    await HandController.PostHand(hand);
                    
                }
                // PLAYER WIN
                else if(playerScore == 21 && dealerScore != 21)
                {
                    Console.WriteLine("PLAYER WINS");
                    hand.PlayerHandTotal = playerScore;
                    hand.DealerHandTotal = dealerScore;
                    hand.WinLoss = "WIN";
                    hand.Player = player;
                    hand.AmountWon = hand.InitialBet * 1.5m;
                    await HandController.PostHand(hand);
                }
                // DRAW
                else if(playerScore == 21 && dealerScore == 21)
                {
                    Console.WriteLine("PLAYER WINS");
                    hand.PlayerHandTotal = playerScore;
                    hand.DealerHandTotal = dealerScore;
                    hand.WinLoss = "WIN";
                    hand.Player = player;
                    await HandController.PostHand(hand);

                }

            }




            return player;
        }

        private static void DisplayCardsBeforeDealerHit(List<Card> playerCards, List<Card> dealerCards)
        {
            Console.WriteLine();
            Console.WriteLine("Dealer's Hand:");
            Console.WriteLine($"{dealerCards[0].Rank} of {dealerCards[0].Suit}");
            Console.WriteLine("*Down Card*");
            Console.WriteLine();
            Console.WriteLine("Your Hand:");
            foreach (Card card in playerCards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }

        private static int CheckHand(List<Card> cards)
        {
            int score = 0;
            foreach(Card card in cards)
            {
                score += card.Value;
            }
            return score;
        }

    }
}
    

