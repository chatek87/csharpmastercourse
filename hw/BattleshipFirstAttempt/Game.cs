namespace BattleshipFirstAttempt;

public class Game
{
    public static int NumberOfPlayers { get; } = 2;
    public static int NumberOfShipsPerPlayer { get; } = 5;
    public static int GridSize { get; } = 5;
    private bool isWon { get; set; }
    public Player[] Players { get; set; }

    public Game()   // instantiate all player objects into Players array
    {
         isWon = false;
        Players = new Player[NumberOfPlayers];

        for (int i = 0; i < NumberOfPlayers; i++)
         {
            Players[i] = new Player();
         }
    }

    public void SetUpGame() // get player names, place ships, then call RunGame()
    {
        ConsoleUtils.GetPlayerNames(Players);
        ConsoleUtils.PlaceShips(Players);
        RunGame();
    }   
    //TODO: finish up game logic.
    // **should RunGame() and TakeTurn() be combined into one method?
    public void RunGame()
    {
        int currentPlayerIndex = 0;
        int opponentPlayerIndex = 0;
        while (!isWon)  // game logic goes inside here
        {
            // get current player
            if (currentPlayerIndex >= NumberOfPlayers)
            {
                currentPlayerIndex = 0;
            }
            // get opponent
            int opponentIndex = currentPlayerIndex + 1;
            if (opponentIndex >= NumberOfPlayers)
            {
                opponentIndex = 0;
            }

            var CurrentPlayer = Players[currentPlayerIndex];
            var CurrentOpponent = Players[opponentIndex];

            // print grids, as well as scores, for current player
            Console.Clear();
            ConsoleUtils.DisplayGameplayScreen(this, currentPlayerIndex, opponentIndex);

            // ask current for shot until valid shot is entered
            string move;
            int col;
            int row;
            do
            {
                move = ConsoleUtils.GetMoveFromConsole();
                col = ValidateCoordinateGetIndex(move).col;
                row = ValidateCoordinateGetIndex(move).row;
            } while (!ValidateCoordinateGetIndex(move).isValid || CurrentOpponent.Grid[col, row].HasBeenFiredUpon);

            //col = ValidateCoordinateGetIndex(move).col;
            //row = ValidateCoordinateGetIndex(move).row;

            // check if hit
            FireShotCheckForHitOrMiss((col, row), CurrentOpponent);

            // check if game won
            if (CurrentOpponent.ShipsRemaining == 0)
            {
                isWon = true;
                ConsoleUtils.DisplayWonMessage(CurrentPlayer);
            }

            ConsoleUtils.NextTurnMessage(CurrentOpponent);
            currentPlayerIndex++;
        }
        // TODO:
        // -> if won, print won message
        // -> ask if user would like to play again
        // -> if yes, reset all grids/scores and run game again
        // -> winner goes first next time?
    }

    public void FireShotCheckForHitOrMiss((int col, int row) index, Player opponentPlayer)
    {
        opponentPlayer.Grid[index.col, index.row].HasBeenFiredUpon = true;
        
        if (opponentPlayer.Grid[index.col, index.row].IsSunk)
        {
            opponentPlayer.ShipsRemaining--;
            Console.WriteLine("THAT'S A HIT!!!");
            ConsoleUtils.WaitForKeyPress();
        }
        else
        {
            Console.WriteLine("you missed :/");
            ConsoleUtils.WaitForKeyPress();
        }
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

    // not sure yet whether to break ValidateCoordinateGetIndex into two separate methods, 
    // but here they are just in case:
    public static bool ValidateMove(string coordinate)
    {
        int col = 0, row = 0;

        if (coordinate.Length != 2 || !char.IsLetter(coordinate[0]) || !char.IsDigit(coordinate[1]))
        {
            return false;
        }

        col = (int)char.ToUpper(coordinate[0]) - (int)'A';
        row = int.Parse(coordinate[1].ToString()) - 1;

        if (row < 0 || row >= GridSize || col < 0 || col >= GridSize)
        {
            return false;
        }
        return true;
    }

    public static (int col, int row) GetMoveIndex(string coordinate)
    {
        int col = (int)char.ToUpper(coordinate[0]) - (int)'A';
        int row = int.Parse(coordinate[1].ToString()) - 1;

        return (col, row);
    }
}