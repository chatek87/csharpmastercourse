namespace hw_MethodOverriding;

// hw: create a Person class and override the ToString() method in it
// make it return the user's first and last name
class Program
{
    static void Main(string[] args)
    {
        var person = new Person { FirstName = "rob", LastName = "thomas", FavoriteSong = "Extra Parmesan" };

        Console.WriteLine(person.ToString()); 

        Console.ReadLine();
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteSong { get; set; }

    public override string ToString()
    {
        return $"Ca{FirstName}ba {LastName}";

    }

}