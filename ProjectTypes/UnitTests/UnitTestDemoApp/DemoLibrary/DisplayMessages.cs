namespace DemoLibrary;

// Red, Green, Refactor

public class DisplayMessages
{
    public string Greeting(string firstName, int hourOfTheDay)
    {
        string output = string.Empty;
        
        if (hourOfTheDay < 5)
        {
            output = $"Go to bed {firstName}";
        }
        else if (hourOfTheDay < 12)
        {
            output = $"Good morning {firstName}";
        }
        else if (hourOfTheDay < 18)
        {
            output = $"Good afternoon {firstName}";
        }
        else
        {
            output = $"Good evening {firstName}";
        }

        return output;
    }
}