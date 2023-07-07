using System.Runtime.CompilerServices;

namespace Lesson_ExtensionMethodsDemo;

class Program
{
    static void Main(string[] args)
    {
        var room = new HotelRoomModel();

        room.TurnOnAir().SetTemperature(69).OpenShades();

        room.TurnOffAir().CloseShades();

        ExtensionSamples.SetTheTemperature(room, 72);   // the other way to do it

        "Hello world".PrintToConsole();

        Console.ReadLine();
    }
}

public class HotelRoomModel
{
    public int Temperature { get; set; }
    public bool IsAirRunning { get; set; }
    public bool AreShadesOpen { get; set; }
}

public static class ExtensionSamples
{
    public static void SetTheTemperature(HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
    }

    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }

    public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.IsAirRunning = true;
        return room;
    }

    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.IsAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = true;
        return room;
    }

    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = false;
        return room;
    }
}