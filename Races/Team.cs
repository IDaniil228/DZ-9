using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public enum Countries { Россия, Франция, Китай, Казахстан }
    internal class Team : IPlayGame
    {
        private Countries country;
        List<Person> people = new List<Person> ();
        public Team(Countries country, BigRaces races) 
        {
            this.country = country;
            races.AddTeams(this); 
        }
        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void PlayGame(Game game)
        {
            game.Play();
            Console.WriteLine($"Команда {country.ToString()}, сыграла в игру {game.Title}");
        }
    }
}
