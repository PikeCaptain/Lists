using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a list with some popular game titles
            List<string> games = new List<string>
            {
                "COTW",
                "Halo Infinite",
                "MInecraft",
                "No Man's Sky",
                "Kill it with fire",
            };

            // Creates an array with a couple more games
            string[] otherGames = new string[]
            {
                "MarioKart",
                "Smash Bros",
            };

            foreach (string game in games) 
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"Games in list: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine(games.Count);

            if (games.Contains("Halo"))
            {
                Console.WriteLine("MASTER CHIEF IS IN THE HOUSE!!")
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if (myInt < games.Count) 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game not found!");
            }

            Console.WriteLine("All games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            
            games.Sort();

            Console.WriteLine("sorted games list:");
            foreach(string game in games)
            {
                Console.WriteLine(game);    
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("New list");
            foreach (string game in newList) 
            {
                Console.WriteLine(game);   
            }
        }
    }
}
