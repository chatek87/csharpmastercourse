using BattleshipLiteLibrary.Models;

namespace BattleshipLiteLibrary;

public static class GameLogic
{
    public static void InitializeGrid(PlayerInfoModel model)
    {
        List<string> letters = new List<string>
        {
            "A",
            "B",
            "C",
            "D",
            "E"
        };

        List<int> numbers = new List<int>
        {
            1,
            2,
            3,
            4,
            5
        };

        foreach (var letter in letters)
        {
            foreach (var number in numbers)
            {
                AddGridSpot(model, letter, number);
            }
        }
    }
    
    private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
    {
        GridSpotModel spot = new GridSpotModel
        {
            SpotLetter = letter,
            SpotNumber = number,
            Status = GridSpotStatus.Empty
        };

        model.ShotGrid.Add(spot);
    }

    public static bool PlaceShip(PlayerInfoModel model, string? location)
    {
        // split location into row & col


        // validate placement
        //      check if spot exists (if row and col is in model.shotgrid)
        //      then check if spot status is vacant (model.shotgrid[spot]gridspotstatus.empty)
        // if valid placement, update that gridspot status to be occupied (gridspotstatus.ship)
        //      return true;
        //  return false
        throw new NotImplementedException();
    }

    public static bool PlayerStillActive(PlayerInfoModel opponent)
    {
        throw new NotImplementedException();
    }

    public static int GetShotCount(PlayerInfoModel winner)
    {
        throw new NotImplementedException();
    }

    public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
    {
        throw new NotImplementedException();
    }

    public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
    {
        throw new NotImplementedException();
    }

    public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
    {
        throw new NotImplementedException();
    }

    public static void MarkShotResult(PlayerInfoModel activePlayer, string row, int column, bool isAHit)
    {
        throw new NotImplementedException();
    }
}