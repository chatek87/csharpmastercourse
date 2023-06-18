namespace hw_UnitTestDemoLibrary.Tests;

public class InstrumentModelTests
{
    [Fact]
    public void PlayNoteShouldReturnInstrumentNameAndNoteValueMessage()
    {
        // Arrange
        InstrumentModel jazzmaster = new InstrumentModel("Fender Jazzmaster");
        string expected = "Fender Jazzmaster played the note A";

        // Act
        string actual = jazzmaster.PlayNote(InstrumentModel.NoteValue.A);         

        // Assert
        Assert.Equal(expected, actual);
    }
}