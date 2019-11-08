using NUnit.Framework;
using RockPaperScissors.Game;
using RockPaperScissors.Rules;
using RockPaperScissors.Rules.Moves;

namespace RockPaperScissorsTests.Rules
{
    [TestFixture]
    public class GameRuleTests
    {
        private const string WRONG_INITIAL = "T";

        [TestCaseSource(nameof(players))]
        public void Player1_should_win_all_matches(Player player1, Player player2)
        {
            var winnerPlayer = GameRule.Winner(player1, player2);

            Assert.AreEqual(player1, winnerPlayer);
        }

        [TestCase(Move_P.INITIAL, true)]
        [TestCase(Move_R.INITIAL, true)]
        [TestCase(Move_S.INITIAL, true)]
        [TestCase(WRONG_INITIAL, false)]
        public void Should_valid_all_moves(string move, bool expectedValid)
        {
            Assert.AreEqual(expectedValid, GameRule.MoveIsValid(move));
        }

        private static object[] players => new object[]
        {
            new object[]
            {
                new Player("Player1", Move_P.INITIAL),
                new Player("Player2", Move_R.INITIAL)
            },
            new object[]
            {
                new Player("Player1", Move_R.INITIAL),
                new Player("Player2", Move_S.INITIAL)
            },
            new object[]
            {
                new Player("Player1", Move_S.INITIAL),
                new Player("Player2", Move_P.INITIAL)
            },
            new object[]
            {
                new Player("Player1", Move_P.INITIAL),
                new Player("Player2", Move_P.INITIAL)
            },
            new object[]
            {
                new Player("Player1", Move_R.INITIAL),
                new Player("Player2", Move_R.INITIAL)
            },
            new object[]
            {
                new Player("Player1", Move_S.INITIAL),
                new Player("Player2", Move_S.INITIAL)
            }
        };
    }
}
