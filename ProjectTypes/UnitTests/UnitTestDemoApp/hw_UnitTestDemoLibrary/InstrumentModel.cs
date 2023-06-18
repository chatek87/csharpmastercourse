namespace hw_UnitTestDemoLibrary;

public class InstrumentModel
{
    public string InstrumentName { get; private set; }

    public InstrumentModel(string instrumentName)
    {
        InstrumentName = instrumentName;
    }

    public string PlayNote(NoteValue note)
    {
        var output = $"{InstrumentName} played the note {note}";
        return output ;
    }

    public enum NoteValue
    {
        A, B, C, D, E, F, G
    }
}