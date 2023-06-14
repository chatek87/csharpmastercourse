namespace Lesson_GenericsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        /*List<string> stringList = new List<string>();
        List<int> intList = new List<int>();

        //intList.Add(1);
        string result = FizzBuzz("tests");
        Console.WriteLine($"string (\"tests\"): {result}\n");

        result = FizzBuzz(123);
        Console.WriteLine($"int (123): {result}\n");

        result = FizzBuzz(true);
        Console.WriteLine($"bool (true): {result}\n");

        result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" });
        Console.WriteLine($"PersonModel: {result}\n");
*/

        GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
        peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "bob", LastName = "jay", HasError = true });

        foreach (var item in peopleHelper.RejectedItems)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} was rejected");
        }

        Console.ReadLine();
    }

    private static string FizzBuzz<T>(T item)
    {
        int itemLength = item.ToString().Length;
        string output = string.Empty;

        if (itemLength % 3 == 0)
        {
            output += "Fizz";
        }

        if (itemLength % 5 == 0) 
        {
            output += "Buzz";
        }

        return output;
    }
}

public class GenericHelper<T> where T : IErrorCheck
{
    public List<T> Items { get; set; } = new List<T>();
    public List<T> RejectedItems { get; set; } = new List<T>();

    public void CheckItemAndAdd(T item)
    {
        if (item.HasError == false)
        {
            Items.Add(item);
        }
        else
        {
            RejectedItems.Add(item);
        }
    }
}

public interface IErrorCheck
{
    bool HasError { get; set; }
}

public class CarModel : IErrorCheck
{
    public string Manufacturer { get; set; }
    public int YearManufactured { get; set; }
    public bool HasError { get; set; }
}

public class PersonModel : IErrorCheck
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool HasError { get; set; }

}