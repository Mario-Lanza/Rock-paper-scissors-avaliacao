namespace RockPaperScissors.Game
{
    public class Player
    {
        public Player(string name, string move)
        {
            Name = name;
            Move = move.ToUpper();
        }

        public string Name { get; private set; }
        public string Move { get; private set; }
    }
}
