namespace Lesson_InheritanceDemo;

class Program
{
    static void Main(string[] args)
    {
        List<Phone> phones = new List<Phone>();

        phones.Add(new Cellphone());
        phones.Add(new LandLine());

        foreach (var phone in phones)
        {
            if (phone is Cellphone cell) 
            {
                cell.Carrier = "";
            }

            if (phone is Smartphone smartphone)
            {
                smartphone.ConnectToInternet();
            }
        }

        Console.ReadLine();
    }
}

public class WalkieTalkie
{

}