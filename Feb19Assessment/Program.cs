// See https://aka.ms/new-console-template for more information
using Feb19Assessment;

class Program
{
    static List<Players> players = new List<Players>();
    static void Main(string[] args)
    {
        players.Add(new Players { Id = 1, Name = "Virat", Age = 25 });
        players.Add(new Players { Id = 2, Name = "Yuvraj", Age = 30 });

        Console.WriteLine("Welcome to Player Management App!");
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n1. Get all players");
            Console.WriteLine("2. Get player by id");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GetAllPlayers();
                    break;
                case "2":
                    GetPlayerById();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void GetAllPlayers()
    {
        Console.WriteLine("\nAll Players:");
        foreach (var player in players)
        {
            Console.WriteLine($"ID: {player.Id}, Name: {player.Name}, Age: {player.Age}");
        }
    }
    static void GetPlayerById()
    {
        Console.Write("Enter player ID: ");
        int id;
        if (int.TryParse(Console.ReadLine(), out id))
        {
            Players player = players.Find(p => p.Id == id);
            if (player != null)
            {
                Console.WriteLine($"\nPlayer found - ID: {player.Id}, Name: {player.Name}, Age: {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid player ID.");
        }
    }
}