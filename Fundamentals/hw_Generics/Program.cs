namespace hw_Generics;

internal class Program
{
    static void Main(string[] args)
    {
        List<object> items = new List<object>();

        var booley = true;
        var number = 69;
        var text = "Hello there!";
        var pi = 3.141592653;
        var otherPi = 3.141592653M;
        var ted = new TeddyBear { Name = "Ted", Color = "brown", FluffLevel = 10 };

        items.Add(booley);
        items.Add(number);
        items.Add(text);
        items.Add(pi);
        items.Add(otherPi);
        items.Add(ted);

        foreach (var item in items)
        {
            PrintItemTypeAndValue(item);
        }

        Console.ReadLine();
    }

    public static void PrintItemTypeAndValue<T>(T item)
    {
        string value = item.ToString();
        Console.WriteLine($"Item type:  {item.GetType()}");
        Console.WriteLine($"Item value: {value}");
        Console.WriteLine();
    }
}

public class TeddyBear
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int FluffLevel { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Color: {Color}, Fluff Level: {FluffLevel}";
    }
}


