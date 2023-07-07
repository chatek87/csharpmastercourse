namespace hw_ExtensionMethodsMiniProject;

internal class Program
{
    static void Main(string[] args)
    {
        var person = new PersonModel();

        person.FirstName = ConsoleHelper.RequestString("What is your first name: ");
        
        person.LastName = "What is your last name: ".RequestString();

        person.Age = "What is your age: ".RequestInt(0, 120);
        // person.Age = ConsoleHelper.RequestInt("What is your age: ", 0, 120);     // equivalent

        Console.ReadLine();
    }
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

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return message.RequestInt(true, minValue, maxValue);
    }

    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
    {
        bool isInValidRange = true;
        bool isValidInt = false;
        int output = 0;

        while (!isValidInt || !isInValidRange)
        {
            Console.Write(message);

            isValidInt = int.TryParse(Console.ReadLine(), out output);

            if (useMinMax == true)
            {
                //isInValidRange = (output >= minValue && output <= maxValue);     // this one-liner is equivalent to the block below:
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

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int NumberOfChildren { get; set; }
}