namespace BattleshipFirstAttempt;

public class Player
{
    public string PlayerName { get; set; }
    public int Score { get; set; }
    public Cell[,] Grid { get; set; }

    public Player() //initialize player, set up player's grid with default values and names
    {
        Score = 0;

        Grid = new Cell[Game.GridSize, Game.GridSize];

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