using Microsoft.Extensions.Configuration;
using MongoDataAccessLibrary;
using MongoDataAccessLibrary.Models;

namespace hw_MongoUI;

public class Program
{
    private static MongoDbDataAccess db;
    private static readonly string tableName = "Employers";

    static void Main(string[] args)
    {
        db = new MongoDbDataAccess("hw_EmployersDB", GetConnectionString()); ;

        //EmployerModel emp = SynthesizeEmployer();
        //CreateEmployer(emp);

        GetAllEmployers();
        
        Console.WriteLine("MongoDB: Processing complete.");

        Console.ReadLine();
    }


    private static EmployerModel SynthesizeEmployer()
    {
        EmployerModel emp = new EmployerModel
        {
            EmployerName = "Mr. Dink's Whacky Whippy Dippy Factory"
        };

        emp.Address.StreetAddress = "123 Funkytown Road";
        emp.Address.City = "Bluffington";
        emp.Address.State = "NJ";
        emp.Address.ZipCode = "45678";

        emp.Employees.Add(new PersonModel { FirstName = "Patty", LastName = "Mayonnaise", JobTitle = "Truck Driver" });
        emp.Employees.Add(new PersonModel { FirstName = "Doug", LastName = "Funnie", JobTitle = "Cone Mascot" });

        return emp;
    }

    //CREATE
    private static void CreateEmployer(EmployerModel employer)
    {
        db.UpsertRecord(tableName, employer.Id, employer);
    }

    //READ
    private static void GetAllEmployers()
    {
        var employers = db.LoadRecords<EmployerModel>(tableName);

        foreach (var employer in employers)
        {
            Console.WriteLine($"Employer name: {employer.EmployerName}");
            Console.WriteLine($"Employer ID: {employer.Id}");
            Console.WriteLine();
            Console.WriteLine($"{employer.Address.StreetAddress}");
            Console.WriteLine($"{employer.Address.City}, {employer.Address.State} {employer.Address.ZipCode}");
            Console.WriteLine();
            Console.WriteLine("Employees: ");
            foreach (var employee in employer.Employees)
            {
                Console.WriteLine($"{employee.LastName}, {employee.FirstName}: {employee.JobTitle}");
            }
        }
    }
    //UPDATE

    //DELETE
    private static void DeleteEmployerById(string id)
    {
        Guid guid = new Guid(id);
        db.DeleteRecord<EmployerModel>(tableName, guid);
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

