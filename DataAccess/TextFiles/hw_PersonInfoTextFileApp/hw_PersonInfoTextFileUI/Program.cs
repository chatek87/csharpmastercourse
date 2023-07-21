using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace hw_PersonInfoTextFileUI;

class Program
{
    private static IConfiguration _config;
    private static string textFile;
    private static TextFileDataAccess db = new();

    static void Main(string[] args)
    {
        //build a csv file that holds person info.
        //load the file into models in C# and save the data from C# back into the csv file.
        //First and last name, 1 email, 1 phone number, isAlive boolean

        InitializeConfiguration();
        textFile = _config.GetValue<string>("TextFile");

        PersonModel person1 = new PersonModel
        {
            FirstName = "Test",
            LastName = "Bobson",
            PhoneNumber = "123",
            EmailAddress = "t.bobson@aol.com"
        };

        CreateContact(person1);

        Console.ReadLine();
    }

    private static void CreateContact(PersonModel contact)
    {
        var person = db.ReadAllRecords(textFile);

        person.Add(contact);

        db.WriteAllRecords(person, textFile);
    }


    private static void InitializeConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        _config = builder.Build();
    }
}