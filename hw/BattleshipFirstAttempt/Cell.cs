namespace BattleshipFirstAttempt
{
    public class Cell
    {
        public string Name { get; set; }
        public bool ContainsShip { get; set; }
        public bool HasBeenFiredUpon { get; set; }
        public bool IsSunk
        {
            get { return ContainsShip && HasBeenFiredUpon; }
        }
    }
}
