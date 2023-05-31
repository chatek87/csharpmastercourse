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

        trumpet.PlayChord();
        trumpet.PlayRaspberry();

        Console.ReadLine();
    }
}
