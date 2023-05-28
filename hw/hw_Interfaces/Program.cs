namespace hw_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Person bob = new Person();
        Animal muskrat = new Animal();

        // store both types in a List<IRun> object
        List<IRun> runners = new List<IRun>();

        runners.Add(bob);
        runners.Add(muskrat);

        foreach (IRun runner in runners)
        {
            runner.Run();
        }

        Console.ReadLine();
    }
}

// hw: create an IRun interface and apply it to a Person class and an Animal class.
public interface IRun
{
    void Run();
}

public class Person : IRun
{
    public string Name { get; set; }
    public string Occupation { get; set; }

    public void Run()
    {
    }
}

public class Animal : IRun
{
    public string Species { get; set; }
    public string Habitat { get; set; }

    public void Run()
    {
    }
}
