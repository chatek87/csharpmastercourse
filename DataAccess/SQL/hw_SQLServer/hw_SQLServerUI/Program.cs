using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System.Net.Http.Headers;

namespace hw_SQLServerUI;

class Program
{
    static void Main(string[] args)
    {
        SqlCrud sql = new SqlCrud(GetConnectionString());
        
        Console.WriteLine("--Querying Personnel--");
        Console.Write("Enter Record ID: ");

        int selection;
        bool isInt = int.TryParse(Console.ReadLine(), out selection);

        ReadPersonById(sql, selection);   

        Console.ReadLine();
    }

    private static void ReadPersonById(SqlCrud sql, int id)
    {
        var person = sql.GetFullPersonById(id);

        Console.WriteLine($"Full Name: {person.PersonInfo.FirstName} {person.PersonInfo.LastName}  ID: {person.PersonInfo.Id}");
        Console.WriteLine();
        
        Console.WriteLine("Known Addresses:");
        foreach (var address in person.Addresses)
        {
            Console.WriteLine($"{address.StreetAddress}");
            Console.WriteLine($"{address.City}, {address.State.ToUpper()} {address.ZipCode}");
            Console.WriteLine();
        }
        
        Console.WriteLine("Known Employers:");
        foreach (var employer in person.Employers)
        {
            Console.WriteLine($"{employer.EmployerName}");
        }
    }

    private static void ReadAllPeople(SqlCrud sql)
    {
        var rows = sql.GetAllPeople();

        foreach (var row in rows)
        {
            Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
        }
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