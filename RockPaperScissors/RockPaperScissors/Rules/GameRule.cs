using RockPaperScissors.Game;
using RockPaperScissors.Rules.Moves;
using System;
using System.Linq;

namespace RockPaperScissors.Rules
{
    public class GameRule
    {
        public static Player Winner(Player player1, Player player2)
        {
            var player1Move = FindPlayerMove(player1);

            return player1Move.WinAgainst(player2.Move) ? player1 : player2;
        }

        public static bool MoveIsValid(string move)
        {
            var allInitialsMoves = ContainerMoves.GetAllInitials();

            return allInitialsMoves.Contains(move);
        }

        private static MoveBase FindPlayerMove(Player player)
        {
            return ContainerMoves.GetAllMoves().Find(move => move.Rule(player.Move));
        }
    }
}
