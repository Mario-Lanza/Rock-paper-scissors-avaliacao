namespace RockPaperScissors.Rules.Moves
{
    public class Move_R : MoveBase
    {
        public const string INITIAL = "R";
        public override string InitialMove => INITIAL;

        protected override string LoseMove()
        {
            return Move_P.INITIAL;
        }
    }
}
