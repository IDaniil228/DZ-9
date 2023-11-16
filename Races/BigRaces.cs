using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    internal class BigRaces
    {
        private List<Team> teams = new List<Team>();
        private List<Game> games = new List<Game>();
        public void AddTeams(Team team)
        {
            teams.Add(team);
        }
        public void AddGame(Game game)
        {
            games.Add(game);
        }
    }
}
