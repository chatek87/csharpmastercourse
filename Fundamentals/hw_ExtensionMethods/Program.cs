namespace hw_ExtensionMethods;


internal class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel { FirstName = "Amelia", LastName = "Bedilia"};
   
        person.SetDefaultAge().PrintInfo();

        Console.ReadLine();
    }
}

public class PersonModel
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

public static class PersonExtensions
{
    private static int defaultAge = 25;

    public static PersonModel SetDefaultAge(this PersonModel person)
    {
        person.Age = defaultAge;
        return person;
    }

    public static PersonModel PrintInfo(this PersonModel person)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
        return person;
    }
}