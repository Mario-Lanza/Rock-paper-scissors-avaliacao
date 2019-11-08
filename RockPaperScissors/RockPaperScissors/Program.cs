using RockPaperScissors.Game;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var tournament = new[]{
                new []
                {
                    new[] { new Player("Armando", "P"), new Player("Dave", "S")},
                    new[] { new Player("Richard", "R"), new Player("Michael", "S") }
                },
                new []
                {
                    new[] { new Player("Allen", "S" ), new Player("Omer", "P") },
                    new[] { new Player("David E.", "R"), new Player("Richard X.", "P") }
                }
            };

            var winner = Tournament.Start(tournament);

            Console.WriteLine("The Winner is {0}", winner.Name);
            Console.ReadKey();
        }
    }
}
