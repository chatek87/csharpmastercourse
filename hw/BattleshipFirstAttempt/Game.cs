namespace BattleshipFirstAttempt;

public class Game
{
    public static int NumberOfPlayers { get; } = 2;
    public static int NumberOfShipsPerPlayer { get; } = 5;
    public static int GridSize { get; } = 5;
    private bool isWon { get; set; }
    public Player[] players = new Player[NumberOfPlayers];

    public Game()   // instantiate all player objects into players array
    {
         isWon = false;

         for (int i = 0; i < NumberOfPlayers; i++)
         {
            players[i] = new Player();
         }
    }

    public void SetUpGame() // get player names, place ships, then call RunGame()
    {
        ConsoleUtils.GetPlayerNames(players);
        ConsoleUtils.PlaceShips(players);
        RunGame();
    }   

    public void RunGame()
    {
        int currentPlayerIndex = 0; 
        while (!isWon)  // game logic goes inside here
        {
            if (currentPlayerIndex >= NumberOfPlayers)
            {
                currentPlayerIndex = 0;
            }
            TakeTurn(currentPlayerIndex);
            currentPlayerIndex++;
        }
        // for each player:
        // ask current player for move
        // validate move
        // check if hit or miss
        // calculate current score
        // if game over, end
    }
    public void TakeTurn(int currentPlayerIndex)
    {
        int opponentIndex = currentPlayerIndex + 1;
        if (opponentIndex >= NumberOfPlayers)
        {
            opponentIndex = 0;
        }
        Player currentPlayer = players[currentPlayerIndex];
        Player opponentPlayer = players[opponentIndex];
//TODO: put logic in to ask for a valid shot repeatedly until one is entered.
// then, we want to return a message of HIT or MissedSymbol, update score, check if game is still not won
        FireShot(currentPlayer, opponentPlayer);
    }

    public void FireShot(Player currentPlayer, Player opponentPlayer)
    {

    }

    public static (int row, int col, bool isValid) ValidateCoordinateGetIndex(string coordinate)
    {
        int row = 0, col = 0;

        if (coordinate.Length != 2 || !char.IsLetter(coordinate[0]) || !char.IsDigit(coordinate[1]))
        {
            return (row, col, false);
        }

        col = (int)char.ToUpper(coordinate[0]) - (int)'A';
        row = int.Parse(coordinate[1].ToString()) - 1;

        if (row < 0 || row >= GridSize || col < 0 || col >= GridSize)
        {
            return (row, col, false);
        }

        return (row, col, true);
    }

}