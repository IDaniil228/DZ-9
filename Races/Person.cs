using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    internal class Person
    {
        string name;
        Team team;
        public Person(string name, Team team)
        {
            this.name = name;
            this.team = team;
            team.AddPerson(this);
        }
    }
}
