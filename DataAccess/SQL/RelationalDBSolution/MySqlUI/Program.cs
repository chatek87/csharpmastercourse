﻿//using DataAccessLibrary;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MySqlUI;

public class Program
{
    static void Main(string[] args)
    {
        MySqlCrud sql = new MySqlCrud(GetConnectionString());

        ReadAllContacts(sql);

        //UpdateContact(sql);

        //ReadContact(sql, 3);

        //CreateNewContact(sql);

        //RemovePhoneNumberFromContact(sql, 1, 1);

        Console.WriteLine("MySQL: Processing complete.");

        Console.ReadLine();
    }

    private static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
    {
        sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
    }

    private static void UpdateContact(MySqlCrud sql)
    {
        BasicContactModel contact = new BasicContactModel
        {
            Id = 1,
            FirstName = "Guisseppe",
            LastName = "Perrone"
        };
        sql.UpdateContactName(contact);
    }

    private static void CreateNewContact(MySqlCrud sql)
    {
        FullContactModel user = new FullContactModel
        {
            BasicInfo = new BasicContactModel
            {
                FirstName = "Bubsie",
                LastName = "McStubbins"
            }
        };

        user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
        user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "me@guckerton.org" });

        user.PhoneNumbers.Add(new PhoneNumberModel { Id = 2, PhoneNumber = "555-6969" });
        user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

        sql.CreateContact(user);
    }

    private static void ReadAllContacts(MySqlCrud sql)
    {
        var rows = sql.GetAllContacts();

        foreach (var row in rows)
        {
            Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
        }
    }

    private static void ReadContact(MySqlCrud sql, int contactId)
    {
        var contact = sql.GetFullContactById(contactId);

        Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
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
