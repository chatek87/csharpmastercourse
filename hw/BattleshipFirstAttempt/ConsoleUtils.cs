namespace BattleshipFirstAttempt;

public static class ConsoleUtils
{
    // symbols to be displayed on current player grid
    public const char ShipSymbol = '*';
    public const char NoShipSymbol = '~';
    // symbols to be displayed on opponent grid
    public const char NotYetFiredUponSymbol = '?';
    public const char SunkSymbol = 'X';
    public const char MissedSymbol = '-';
    
    
    // get user input methods
    public static void GetPlayerNames(Player[] players)
    {
        int i = 1;
        foreach (Player player in players)
        {
            Console.Write($"Player {i}, what should we call you? ");
            player.PlayerName = Console.ReadLine();
            i++;
        }
    }
    public static void PlaceShips(Player[] players)
    {
        foreach (Player player in players)
        {
            Console.Clear();
            Console.WriteLine($"{player.PlayerName}, it is time to place your {Game.NumberOfShipsPerPlayer} ships!");
            Console.WriteLine($"For each ship, enter a coordinate between A1 and E5");
            Console.WriteLine();
            WaitForKeyPress();

            int shipsPlaced = 0;
            while (shipsPlaced < Game.NumberOfShipsPerPlayer)
            {
                Console.Clear();
                DisplayCurrentPlayerGrid(player);
                Console.WriteLine();
                Console.Write($"{player.PlayerName} Ship #{shipsPlaced + 1} coordinate: ");
                var input = Console.ReadLine();
                var coordinate = Game.ValidateCoordinateGetIndex(input);
                if (!coordinate.isValid)
                {
                    Console.WriteLine("Please enter a valid coordinate between A1 and E5");
                    WaitForKeyPress();
                }
                else if (coordinate.isValid && player.Grid[coordinate.row, coordinate.col].ContainsShip == true)
                {
                    Console.WriteLine("This coordinate is already occupied by one of your ships");
                    WaitForKeyPress();
                }
                else if (coordinate.isValid && player.Grid[coordinate.row, coordinate.col].ContainsShip == false)
                {
                    player.Grid[coordinate.row, coordinate.col].ContainsShip = true;
                    shipsPlaced++;
                }
            }
            Console.Clear();
            DisplayCurrentPlayerGrid(player);
            Console.WriteLine();
            Console.WriteLine("All ships added!");
            WaitForKeyPress();
        }
    }
    public static string? GetMoveFromConsole()
    {
        Console.Write("Enter your move: ");
        var move = Console.ReadLine();
        return move;
    }
    // display on console methods
    public static void DisplayWelcomeScreen()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Battleship Lite!");
            Console.WriteLine();
            Console.WriteLine("Please enter a selection...");
            Console.WriteLine("1 - Start the game!");
            Console.WriteLine("2 - Instructions");
            Console.WriteLine("3 - Exit");

            var userSelection = Console.ReadKey(true);
            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    //Console.WriteLine("you selected 1");
                    //Console.ReadKey(true);
                    Game game = new Game();
                    game.SetUpGame();
                    
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    DisplayInstructions();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey(true);
                    break;
                case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    Console.Clear();
                    Console.WriteLine("Press ENTER to confirm, anything else to go back");
                    var confirmLeave = Console.ReadKey();
                    if (confirmLeave.Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select 1, 2, or 3");
                    WaitForKeyPress();
                    break;
            }
        }

    }
    public static void DisplayInstructions()
    {
        Console.Clear();
        Console.WriteLine(@"
""INSTRUCTIONS RAP"" by GPThug$

Listen up, it's time to play a game of skill,
Battleship style, let the excitement thrill!
Two Players ready, with grids of five by five,
A1 to E5, where their ships will dive.

Each player's got 5 pegs, representing their fleet,
Placing them strategically, oh so neat.
One peg per ship, no more, no less,
On unoccupied spaces, let's progress!

Coordinate your moves, choose wisely each time,
Fire your shots, aim with rhythm and rhyme.
You can't hit the same space, remember the rule,
Once it's pegged, move on, don't act a fool!

So gather your ships, get ready to play,
In this Battleship - style game, have fun and slay.
Strategize, aim true, and hit with might,
Let the battle begin, let your skills take flight!

Enjoy the game, and may the best player win,
With each hit and sunk ship, let the victory begin!

                                                ");
    }
    public static void NextTurnMessage(Player nextPlayer)
    {
        Console.Clear();
        Console.WriteLine($"{nextPlayer.PlayerName}, it's your turn!");
        WaitForKeyPress();
    }
    public static void DisplayGameplayScreen(Game game, int currentPlayerIndex, int currentOpponentIndex)
    {
        Console.WriteLine($"{game.Players[currentOpponentIndex].PlayerName}");
        Console.WriteLine($"Ships Remaining: { game.Players[currentOpponentIndex].ShipsRemaining}");
        DisplayCurrentOpponentGrid(game.Players[currentOpponentIndex]);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        DisplayCurrentPlayerGrid(game.Players[currentPlayerIndex]);
        Console.WriteLine($"{game.Players[currentPlayerIndex].PlayerName}");
        Console.WriteLine($"Ships Remaining: {game.Players[currentPlayerIndex].ShipsRemaining}");
        Console.WriteLine();
    }
    public static void DisplayCurrentPlayerGrid(Player player)
    {
        PrintCell(' ');
        for (int col = 0; col < Game.GridSize; col++)
        {
            PrintCell((char)('A' + col));
        }
        Console.WriteLine();

        for (int row = 0; row <Game.GridSize; row++)
        {
            Console.Write((row + 1).ToString().PadLeft(2) + " ");

            for (int col = 0; col < Game.GridSize; col++)
            {
                if (player.Grid[row, col].ContainsShip)
                {
                    PrintCell(ShipSymbol);
                }
                else
                {
                    PrintCell(NoShipSymbol);
                }
            }
            Console.WriteLine();
        }
    }
    public static void DisplayCurrentOpponentGrid(Player player)
    {
        PrintCell(' ');
        for (int col = 0; col < Game.GridSize; col++)
        {
            PrintCell((char)('A' + col));
        }
        Console.WriteLine();

        for (int row = 0; row < Game.GridSize; row++)
        {
            Console.Write((row + 1).ToString().PadLeft(2) + " ");

            for (int col = 0; col < Game.GridSize; col++)
            {
                if (player.Grid[row, col].IsSunk)
                {
                    PrintCell(SunkSymbol);
                }
                else if (player.Grid[row, col].HasBeenFiredUpon && !player.Grid[row, col].ContainsShip)
                {
                    PrintCell(MissedSymbol);
                }
                else
                {
                    PrintCell(NotYetFiredUponSymbol);
                }
            }
            Console.WriteLine();
        }
    }
    public static void PrintCell(char cellSymbol)
    {
        Console.Write($" {cellSymbol} ");
    }
    public static void DisplayWonMessage(Player winner)
    {
        Console.Clear();
        Console.WriteLine($"Congratulations, {winner.PlayerName}, YOU WON!!!!!");
        Console.WriteLine();
        Console.WriteLine();

        Console.ReadKey();
        Environment.Exit(0);
    }
    // various utils
    public static void WaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }

}