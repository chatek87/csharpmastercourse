using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class TextFileDataAccess
{
    public List<PersonModel> ReadAllRecords(string textFile)
    {
        if (!File.Exists(textFile))
        {
            return new List<PersonModel>();
        }

        var lines = File.ReadAllLines(textFile);
        List<PersonModel> output = new List<PersonModel>();

        foreach (var line in lines)
        {
            PersonModel person = new PersonModel();
            var vals = line.Split(',');

            if (vals.Length < 4)
            {
                throw new Exception($"Invalid row of data: {line}");
            }

            person.FirstName = vals[0];
            person.LastName = vals[1];
            person.PhoneNumber = vals[2];
            person.EmailAddress = vals[3];
        }

        return output;
    }

    public void WriteAllRecords(List<PersonModel> people, string textFile)
    {
        List<string> lines = new List<string>();

        foreach (var p in people)
        {
            lines.Add($"{p.FirstName},{p.LastName},{p.PhoneNumber},{p.EmailAddress}");
        }

        File.WriteAllLines(textFile, lines);
    }
}
