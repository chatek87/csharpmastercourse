using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace CosmosDBUI;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CosmosDB: Processing complete.");
        Console.ReadLine();
    }


    private static void RemoveUser(string id)
    {
   
    }

    public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
    {

    }

    private static void UpdateContactsFirstName(string firstName, string id)
    {

    }

    private static void GetContactById(string id)
    {

    }

    private static void GetAllContacts()
    {
     
    }

    private static void CreateContact(ContactModel contact)
    {

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