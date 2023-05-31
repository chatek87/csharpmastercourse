namespace hw_AbstractClasses;

public class Trumpet : MusicalInstrument, IMelodic
{
    public MuteTypes TypeOfMute { get; set; }

    public void PlayNote(int noteLength, int noteValue)
    {
        throw new NotImplementedException();
    }

    public void PlayRaspberry()
    {
        // play raspberry
    }
}
