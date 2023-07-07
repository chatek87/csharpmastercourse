namespace hw_GuestBookMiniProject;

internal class BookKeeper
{
    internal void AddParty(Dictionary<string, int> guestbook)
    {
        Console.Write("What name is your party under? ");
        var name = Console.ReadLine();

        int size = 0;
        bool isNum = false;
        while (!isNum)
        {
            Console.Write("How many guests are in your party? ");
            isNum = int.TryParse(Console.ReadLine(), out size);
        }
        guestbook.Add(name, size);
    }

    internal void PrintAllParties(Dictionary<string, int> guestbook)
    {
        Console.WriteLine("Guest list: ");
        foreach (var party in guestbook)
        {
            Console.WriteLine($"{party.Key}, party of {party.Value}");
        }
    }
    internal void PrintGuestCount(Dictionary<string, int> guestbook)
    {
        int guestCount = 0;
        foreach (var party in guestbook)
        {
            guestCount += party.Value;
        }
        Console.WriteLine(guestCount + " guests in attendance.");
    }
}