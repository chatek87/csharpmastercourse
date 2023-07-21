using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MongoDBUI;

public class Program
{
    private static MongoDbDataAccess db;
    private static readonly string tableName = "Contacts";

    static void Main(string[] args)
    {
        db = new MongoDbDataAccess("MongoContactsDB", GetConnectionString());

        ContactModel user = new ContactModel
        {
            FirstName = "Tim",
            LastName = "Corey"
        };
        user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "erin@erin.com" });
        user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "bubsie@mcstubbins.com" });
        user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "123-4567" });
        user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "888-4567" });

        //CreateContact(user);
        //GetContactById("35cf55ef-92ee-4241-a3f2-af3c4da44d0b");
        //35cf55ef-92ee-4241-a3f2-af3c4da44d0b
        //eb95d641-79ca-4af1-a73c-3e8474dfc71f
        //UpdateContactsFirstName("Charlie", "eb95d641-79ca-4af1-a73c-3e8474dfc71f");
        //RemovePhoneNumberFromUser("999-4567", "eb95d641-79ca-4af1-a73c-3e8474dfc71f");
        //GetAllContacts();

        RemoveUser("eb95d641-79ca-4af1-a73c-3e8474dfc71f");
        GetAllContacts();


        Console.WriteLine("MongoDB: Processing complete.");
        Console.ReadLine();
    }

    private static void RemoveUser(string id)
    {
        Guid guid = new Guid(id);
        db.DeleteRecord<ContactModel>(tableName, guid);
    }

    public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        contact.PhoneNumbers = contact.PhoneNumbers.Where(x  => x.PhoneNumber != phoneNumber).ToList();

        db.UpsertRecord(tableName, contact.Id, contact);
    }

    private static void UpdateContactsFirstName(string firstName, string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        contact.FirstName = firstName;

        db.UpsertRecord(tableName, contact.Id, contact);
    }

    private static void GetContactById(string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);
        Console.WriteLine($"{contact.Id}: {contact.LastName}, {contact.FirstName}");
    }

    private static void GetAllContacts()
    {
        var contacts = db.LoadRecords<ContactModel>(tableName);

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.LastName}, {contact.FirstName}");
        }
    }

    private static void CreateContact(ContactModel contact)
    {
        db.UpsertRecord(tableName, contact.Id, contact);
    }

    private static string GetConnectionString(string connectionStringName = "Default")
    {
        string output = "";

        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();

        output = config.GetConnectionString(connectionStringName);

        return output;
    }
}
