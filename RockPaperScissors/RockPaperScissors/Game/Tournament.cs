using RockPaperScissors.Exceptions;
using RockPaperScissors.Rules;
using System.Linq;

namespace RockPaperScissors.Game
{
    public class Tournament
    {
        public static Player Start(object[] players)
        {
            return Rock_paper_scissors_tournament(players);
        }

        private static Player Rock_paper_scissors_tournament(object[] possiblePlayers)
        {
            if (!ArePlayers(possiblePlayers))
            {
                return Rps_game_winner(Rock_paper_scissors_tournament((object[])possiblePlayers[0]),
                                       Rock_paper_scissors_tournament((object[])possiblePlayers[1]));
            }

            var players = (Player[])possiblePlayers;
            return Rps_game_winner(players);
        }

        private static Player Rps_game_winner(params Player[] players)
        {
            if (players.Count() != 2) throw new WrongNumberOfPlayersError();

            var player1 = players[0];
            var player2 = players[1];

            if (!GameRule.MoveIsValid(player1.Move) || !GameRule.MoveIsValid(player2.Move))
                throw new NoSuchStrategyError();

            return GameRule.Winner(player1, player2);
        }

        private static bool ArePlayers(object[] possiblePlayers)
        {
            return possiblePlayers[0].GetType() == typeof(Player);
        }
    }
}
