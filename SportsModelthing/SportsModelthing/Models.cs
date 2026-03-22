using System.Collections.Generic;

namespace SportsModelAssignment
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Roster> Rosters { get; set; } = new List<Roster>();
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Roster> Rosters { get; set; } = new List<Roster>();
    }

    public class Roster
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public Team Team { get; set; }
        public Player Player { get; set; }
    }
}
