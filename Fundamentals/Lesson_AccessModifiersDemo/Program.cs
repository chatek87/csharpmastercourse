using Lesson_AccessModifiersDemoLibrary;

namespace Lesson_AccessModifiersDemo;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.SavePerson();

        Console.ReadLine();
    }
}

public class CEO : Manager
{
    public void GetConnectionInfo()
    {
        DataAccess data = new DataAccess();
        formerLastName = "test";
    }
}