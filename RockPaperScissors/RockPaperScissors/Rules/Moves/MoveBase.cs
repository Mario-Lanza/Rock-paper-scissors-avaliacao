namespace RockPaperScissors.Rules.Moves
{
    public abstract class MoveBase
    {
        public abstract string InitialMove { get; }

        public bool Rule(string move)
        {
            return move.ToUpper() == InitialMove;
        }

        public bool WinAgainst(string move)
        {
            return LoseMove() != move;
        }

        protected abstract string LoseMove();
    }
}
