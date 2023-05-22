namespace BattleshipFirstAttempt
{
    public class Player
    {
        public string PlayerName { get; set; }

        private int shipsRemaining;
        public int ShipsRemaining
        {
            get { return shipsRemaining; }
            set
            {
                shipsRemaining = value;

                int sunkenShipsCount = 0;

                if (Grid != null)
                {
                    foreach (Cell cell in Grid)
                    {
                        if (cell != null && cell.ContainsShip && cell.HasBeenFiredUpon)
                        {
                            sunkenShipsCount++;
                        }
                    }
                }

                shipsRemaining = Game.NumberOfShipsPerPlayer - sunkenShipsCount;
            }
        }

        public Cell[,] Grid { get; set; }

        public Player()
        {
            Grid = new Cell[Game.GridSize, Game.GridSize];
            ResetGridAndScore();
        }

        private void ResetGridAndScore()
        {
            ShipsRemaining = Game.NumberOfShipsPerPlayer;

            for (int row = 0; row < Game.GridSize; row++)
            {
                for (int col = 0; col < Game.GridSize; col++)
                {
                    Grid[row, col] = new Cell
                    {
                        Name = ((char)('A' + col)).ToString() + (row + 1).ToString(),
                        ContainsShip = false,
                        HasBeenFiredUpon = false
                    };
                }
            }
        }
    }
}
