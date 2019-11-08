namespace RockPaperScissors.Rules.Moves
{
    public class Move_S : MoveBase
    {
        public const string INITIAL = "S";
        public override string InitialMove => INITIAL;

        protected override string LoseMove()
        {
            return Move_R.INITIAL;
        }
    }
}
