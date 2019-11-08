namespace RockPaperScissors.Rules.Moves
{
    public class Move_P : MoveBase
    {
        public const string INITIAL = "P";
        public override string InitialMove => INITIAL;

        protected override string LoseMove()
        {
            return Move_S.INITIAL;
        }
    }
}
