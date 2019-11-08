using System.Collections.Generic;

namespace RockPaperScissors.Rules.Moves
{
    public class ContainerMoves
    {
        public static List<MoveBase> GetAllMoves()
        {
            return AllMoves;
        }

        public static IEnumerable<string> GetAllInitials()
        {
            var initialMoveList = new List<string>();
            AllMoves.ForEach(move => initialMoveList.Add(move.InitialMove));
            return initialMoveList;
        }

        private static readonly List<MoveBase> AllMoves = new List<MoveBase>
        {
            new Move_P(),
            new Move_R(),
            new Move_S()
        };
    }
}
