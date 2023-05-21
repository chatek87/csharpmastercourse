namespace GuestBook.Library.Models;

public class GuestModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MessageToHost { get; set; }

    public string GuestInfo
    {
        get
        {
            return $"{FirstName} {LastName}: {MessageToHost}";
        }
    }
    public void DisplayNameAndMessage()
    {
        Console.WriteLine($"Guest: {FirstName} {LastName}");
        Console.WriteLine($"Message: {MessageToHost}");
    }
}