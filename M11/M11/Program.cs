using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11
{
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }
    class PlayerImplementation
    {
        public double Average(IList<Player>players)
        {
            var result = players.Average(p => p.Score);
            return Convert.ToInt32(result);
        }
        public int Max(IList<Player>players)
        {
            var result = players.Max(p => p.Score);
            return result;
        }
        public int Min(IList<Player>players)
        {
            var result = players.Min(p => p.Score);
            return Convert.ToInt32(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "A", Team = "A", Score = 5 });
            players.Add(new Player { Name = "A", Team = "A", Score = 6 });
            players.Add(new Player { Name = "A", Team = "A", Score = 7 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine(playerImplementation.Average(players));
            Console.WriteLine(playerImplementation.Max(players)); 
            Console.WriteLine(playerImplementation.Min(players));

        }
    } 
}
