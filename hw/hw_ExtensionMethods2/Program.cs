namespace hw_ExtensionMethods2;

internal class Program
{
    static void Main(string[] args)
    {

        Console.ReadLine();
    }
}

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string FavoriteAlbum { get; set; }

}

public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;
    }

    public static int RequestInt(this string message)
    {
        return RequestInt(message, false);
    }

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return RequestInt(message, true, minValue, maxValue);
    }

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
    {
        bool isInValidRange = true;
        bool isValidInt = false;
        int output = 0;

        while (!isValidInt || !isInValidRange)  // run loop until both isValidInt and isInValidRange evaluate to true
        {
            Console.WriteLine(message);
            // check for valid int
            isValidInt = int.TryParse(Console.ReadLine(), out output);
            // check for valid range
            if (useMinMax == true)
            {
                if (output >= minValue && output <= maxValue)
                {
                    isInValidRange = true;
                }
                else
                {
                    isInValidRange = false;
                }
            }
        }

        return output;
    }
}