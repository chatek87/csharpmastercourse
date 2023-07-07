namespace hw_Methods;

// create a welcome method,
// a method to ask the user's name,
// and another to tell the user "Hello, <name>".
// call these methods from program.cs

internal class Helper
{
    internal void Welcome()
    {
        Console.WriteLine("Welcome, generic person!");
    }

    internal void Welcome(string name)
    {
        Console.WriteLine($"Welcome, {name}!");
    }

    internal string GetName()
    {
        Console.WriteLine("What's yer name?");
        var name = Console.ReadLine();
        return name;
    }


}