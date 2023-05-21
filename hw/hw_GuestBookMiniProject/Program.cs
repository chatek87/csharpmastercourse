using hw_GuestBookMiniProject;

// build a console guest book - dictionary<key string partyname, value int guestscount>
// ask the user for their name and how many are in their party - parse input via readline into guestbook dictionary
// keep track of how many people are at the party   - foreach party in guestbook, add guestcounts
// at the end, print out the guest list and the total number of guests

// methods to implement: AddParty(), PrintGuestCount()

Dictionary<string, int> guestbook = new();

BookKeeper bookKeeper = new();

bool finished = false;
while (!finished)
{
    bookKeeper.AddParty(guestbook);

    Console.Write("Finished adding? (yes/no): ");
    var answer = Console.ReadLine();
    if (answer.ToLower() == "y" || answer.ToLower() == "yes")
    {
        finished = true;
    }
    //answer.ToLower().Equals("y");
}

bookKeeper.PrintAllParties(guestbook);
bookKeeper.PrintGuestCount(guestbook);

Console.ReadKey();