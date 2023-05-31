namespace hw_AbstractClasses;

public class Xylophone : PercussionInstrument, IPolyphonic
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
