namespace BattleshipFirstAttempt
{
    public class Cell
    {
        public string Name { get; set; }
        public bool ContainsShip { get; set; }
        public bool HasBeenFiredUpon { get; set; }
        public bool IsSunk => ContainsShip && HasBeenFiredUpon;
        /*public bool IsSunk        // this is equivalent to above but more verbose
        {
            get { return ContainsShip && HasBeenFiredUpon; }
        }*/
    }

    // not sure if i should encapsulate '(int column, int row) coordinate' tuple into one struct such as:
    /*public struct CellIndex
    {
        public int Column { get; }
        public int Row { get; }

        public CellIndex(int column, int row)
        {
            Column = column;
            Row = row;
        }
    }*/

}
