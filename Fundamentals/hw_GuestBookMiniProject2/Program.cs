using GuestBook.Library;
using GuestBook.Library.Models;

// capture the info about each guest (assumption is at least one guest and unknown maximum)

// first name, last name, message to the host

// once done, loop thru each guest and print their info

var guests = new List<GuestModel>(); 

GetGuestInfo(guests);

PrintGuestBook(guests);

Console.ReadKey();

static string GetInfoFromConsole(string message)
{
    Console.Write(message);
    string output = Console.ReadLine();
    return output;
}
static void PrintGuestBook(List<GuestModel> guests)
{
    foreach (GuestModel guest in guests)
    {
        guest.DisplayNameAndMessage();
        Console.WriteLine();
    }
}
static void GetGuestInfo(List<GuestModel> guests)
{
    string moreGuestsComing = "";

    do
    {
        var guest = new GuestModel();
        guest.FirstName = GetInfoFromConsole("What is your first name: ");
        guest.LastName =GetInfoFromConsole("What is your last name: ");
        guest.MessageToHost = guest.FirstName = GetInfoFromConsole("What message would you like to tell your host: ");
        guests.Add(guest);
        
        moreGuestsComing = GetInfoFromConsole("Are more guests coming? (yes/no): ");

        Console.Clear();
    } while (moreGuestsComing.ToLower() == "yes" || moreGuestsComing.ToLower() == "y");
}

