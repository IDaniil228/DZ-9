using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    internal class Game : IPlay
    {

        private readonly string title;

        public string Title
        {
            get { return title; }
        }
        public Game(string title, BigRaces races) 
        {
            this.title = title;
            races.AddGame(this);
        }
        public void Play()
        {
            Console.WriteLine($"Игра {title} началась!!!");
        }
    }
}
