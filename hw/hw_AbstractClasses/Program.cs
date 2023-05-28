namespace hw_AbstractClasses;

// create an abstract class that has an interface applied to it
// when instantiating the child class, store it using the interface type
class Program
{
    static void Main(string[] args)
    {
        List<IMelodic> band = new List<IMelodic>();

        Trumpet trumpet = new Trumpet();
        Xylophone xylophone = new Xylophone();
        DrumSet drumSet = new DrumSet();   

        band.Add(trumpet);
        band.Add(xylophone);
        //band.Add(drumSet); cannot add bc not IMelodic

        trumpet.TypeOfMute = MuteTypes.Plunger;
        xylophone.TypeOfSticks = StickTypes.Metal;
        //drumSet.NumberOfDrums = 25;
        
        //drumSet.
        trumpet.PlayRaspberry();

        Console.ReadLine();
    }
}

public interface IMelodic
{
    void PlayNote(int noteLength, int noteValue);
    void PlayChord(List<int> noteValues);
}

public abstract class MusicalInstrument
{
    public string Description { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

}

public abstract class PercussionInstrument : MusicalInstrument
{
    public StickTypes TypeOfSticks { get; set; }
}

public class DrumSet : PercussionInstrument
{
    public int NumberOfDrums { get; set; }
}

public class Xylophone : PercussionInstrument, IMelodic
{
    public int NumberOfKeys { get; set; }

    public void PlayChord(List<int> noteValues)
    {
        throw new NotImplementedException();
    }

    public void PlayNote(int noteLength, int noteValue)
    {
        throw new NotImplementedException();
    }
}

public class Trumpet : MusicalInstrument, IMelodic
{
    public MuteTypes TypeOfMute { get; set; }

    public void PlayChord(List<int> noteValues)
    {
        throw new NotImplementedException();
    }

    public void PlayNote(int noteLength, int noteValue)
    {
        throw new NotImplementedException();
    }

    public void PlayRaspberry()
    {
        // play raspberry
    }
}

public enum StickTypes
{
    WoodHard,
    WoodMedium,
    WoodSoft,
    Metal,
    Rubber,
    Plastic,
    WireBrush
}

public enum MuteTypes
{
    Straight,
    Harmon,
    Plunger
}