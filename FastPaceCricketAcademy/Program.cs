using CricketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPaceCricketAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FastPace Cricket Academy Team Management System!");
            Console.WriteLine();
            OneDayTeam team = new OneDayTeam();
            string ans;
            do
            {
                Console.WriteLine("Enter Your Choice \n1.To Add Player \n2.To Remove Player by Id \n3.Get Player By Id \n4.Get Player by Name \n5.Get All Players:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter Player Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Player Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Player Age: ");
                            int age = int.Parse(Console.ReadLine());
                            team.Add(new Player(id, name, age));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Player Id to Remove:");
                        int playerId = int.Parse(Console.ReadLine());
                        team.Remove(playerId);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player Id:");
                        playerId = int.Parse(Console.ReadLine());
                        Player player = team.GetPlayerById(playerId);
                        if (player != null)
                        {
                            Console.WriteLine($"Player info: {player.PlayerId} \t {player.PlayerName} \t {player.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();
                        player = team.GetPlayerByName(playerName);
                        if (player != null)
                        {
                            Console.WriteLine($"Player info: {player.PlayerId} \t {player.PlayerName} \t {player.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found.");
                        }
                        break;
                    case 5:
                        List<Player> players = team.GetAllPlayers();
                        foreach (Player p in players)
                        {
                            Console.WriteLine($"Player info: {p.PlayerId} \t {p.PlayerName} \t {p.PlayerAge}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine("Do you want to continue (yes/no)?:");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "Yes" || ans == "Y" || ans == "y");
            if (ans == "no" || ans == "No" || ans == "n" || ans == "N")
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
