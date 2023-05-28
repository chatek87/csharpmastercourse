namespace Lesson_InterfaceDemo;

class Program
{
    // Interface is a contract
    // Classes implement an interface
    static void Main(string[] args)
    {
        List<IComputerController> controllers = new List<IComputerController>();
        
        Keyboard keyboard = new Keyboard();
        GameController gameController = new GameController();
        BatteryPowerGameController batteryPowered = new BatteryPowerGameController();

        controllers.Add(keyboard);
        controllers.Add(gameController);
        controllers.Add(batteryPowered);

        foreach (IComputerController controller in controllers)
        {

        }

        using (GameController gc = new GameController())
        {

        }

        List<IBatteryPowered> powereds = new List<IBatteryPowered>();

        powereds.Add(batteryPowered);

        Console.ReadLine();
    }
}

public interface IComputerController
{
    void Connect();
    void CurrentKeyPressed();
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}

public class Keyboard : IComputerController
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed() 
    {

    }

    public string ConnectionType { get; set; }
}

public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {
    }

    public void CurrentKeyPressed()
    {
    }

    public void Dispose()
    {
        // do whatever shutdown tasks needed
    }

}

public class BatteryPowerGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}