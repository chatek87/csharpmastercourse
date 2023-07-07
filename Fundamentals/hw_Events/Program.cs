namespace hw_Events;

// create an event in a class and then consume that class.
// attach a listener to the event and have it write to the console.

internal class Program
{
    static void Main(string[] args)
    {
        EnsembleModel stringQuartet = new EnsembleModel("The Cool Quartet", 4);

        stringQuartet.ConductorCue += StringQuartet_ConductorCue;

        stringQuartet.AddInstrumentToEnsemble("violin 1").PrintString();
        stringQuartet.AddInstrumentToEnsemble("violin 2").PrintString();
        stringQuartet.AddInstrumentToEnsemble("viola").PrintString();
        stringQuartet.AddInstrumentToEnsemble("cello").PrintString();


        Console.ReadLine();
    }

    private static void StringQuartet_ConductorCue(object sender, string e)
    {
        EnsembleModel model = (EnsembleModel)sender;

        Console.WriteLine($"{model.EnsembleName} is ready to play!");
        Console.WriteLine();

        foreach (var player in model.Players)
        {
            player.PlayNote();
        }
    }
}

public static class ConsoleHelper
{
    public static void PrintString(this string message)
    {
        Console.WriteLine(message);
    }
}

public class EnsembleModel
{
    // EventHandler- defines signature of methods that can handle the event
    public event EventHandler<string> ConductorCue;
    public int NumberOfParts { get; private set; }
    public string EnsembleName { get; set; }
    public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
    
    public EnsembleModel(string ensembleName, int numberOfParts)
    {
        NumberOfParts = numberOfParts;
        EnsembleName = ensembleName;
    }

/*    public override string ToString()
    {
        return $"Ensemble name: {EnsembleName}, Musicians: {NumberOfParts}";
    }
*/
    public string AddInstrumentToEnsemble(string instrumentName)
    {
        string output = "";
        var instrument = new PlayerModel(instrumentName);
        
        if (Players.Count < NumberOfParts)
        {
            Players.Add(instrument);
            output = $"{instrument.InstrumentName} was added to {EnsembleName}";

            if (Players.Count == NumberOfParts)
            {
                Console.WriteLine();
                ConductorCue?.Invoke(this, $"Conductor: Alright, {EnsembleName}, everyone is here. Let's get started!");
                Console.WriteLine();
            }

        }
        else
        {
            output = $"{EnsembleName} has already started playing!";
        }

        return output;
        
    }
}

public class PlayerModel
{

    public string InstrumentName { get; set; }

    public PlayerModel(string instrumentName)
    {
        InstrumentName = instrumentName;
    }

    public void PlayNote()
    {
        Console.WriteLine($"{InstrumentName} played a note.");
    }

}

