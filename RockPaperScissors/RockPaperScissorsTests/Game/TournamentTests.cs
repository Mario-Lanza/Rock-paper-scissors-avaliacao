using NUnit.Framework;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Game;

namespace RockPaperScissorsTests.Game
{
    [TestFixture]
    public class TournamentTests
    {
        [Test]
        public void Should_be_richard_winner()
        {
            var expectedWinnerName = "Richard";
            var players = GetPlayers();

            var winner = Tournament.Start(players);

            Assert.AreEqual(expectedWinnerName, winner.Name);
        }

        [Test]
        public void Should_throw_exception_if_number_of_players_are_odd()
        {
            Assert.Throws<WrongNumberOfPlayersError>(() => Tournament.Start(GetPlayersOdd()));
        }

        [Test]
        public void Should_throw_exception_if_a_player_move_is_wrong()
        {
            Assert.Throws<NoSuchStrategyError>(() => Tournament.Start(GetPlayersWrongInitials()));
        }

        private object[] GetPlayersWrongInitials()
        {
            return new[] { new Player("Armando", "P"), new Player("Dave", "T") };
        }

        private object[] GetPlayersOdd()
        {
            return new[]
            {
                new[] { new Player("Armando", "P"), new Player("Dave", "S")},
                new[] { new Player("Richard", "R") }
            };
        }

        private object[] GetPlayers()
        {
            return new[]{
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
        }
    }
}
