using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace SportsModelAssignment
{
    class Program
    {
        public static string MyNameIs => "Joshua Greene"; 

        static void Main(string[] args)
        {
            Console.WriteLine(MyNameIs);
            Console.WriteLine("-----------------------------");

            XDocument doc = XDocument.Load("sports.xml");

            // Load Teams
            List<Team> teams = doc.Descendants("Team")
                .Select(t => new Team
                {
                    Id = (int)t.Attribute("Id"),
                    Name = (string)t.Attribute("Name")
                }).ToList();

            // Load Players
            List<Player> players = doc.Descendants("Player")
                .Select(p => new Player
                {
                    Id = (int)p.Attribute("Id"),
                    Name = (string)p.Attribute("Name")
                }).ToList();

            // Load Rosters
            List<Roster> rosters = doc.Descendants("Roster")
                .Select(r => new Roster
                {
                    TeamId = (int)r.Attribute("TeamId"),
                    PlayerId = (int)r.Attribute("PlayerId")
                }).ToList();

            // Rebuild Relationships
            foreach (Roster r in rosters)
            {
                r.Team = teams.First(t => t.Id == r.TeamId);
                r.Player = players.First(p => p.Id == r.PlayerId);

                r.Team.Rosters.Add(r);
                r.Player.Rosters.Add(r);
            }

            // LINQ Query: Teams and their players
            var result = teams.Select(t => new
            {
                TeamName = t.Name,
                Players = t.Rosters.Select(r => r.Player.Name)
            });

            // Display
            foreach (var team in result)
            {
                Console.WriteLine("Team: " + team.TeamName);

                foreach (var player in team.Players)
                {
                    Console.WriteLine("  - " + player);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
