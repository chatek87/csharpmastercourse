using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class SqliteCrud
{
    private readonly string _connectionString;
    private SqliteDataAccess db = new SqliteDataAccess();

    public SqliteCrud(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<PersonModel> GetAllPeople()
    {
        string sql = "select Id, FirstName, LastName from People";

        return db.LoadData<PersonModel, dynamic>(sql, new { }, _connectionString);
    }

    public FullPersonModel GetFullPersonById(int id)
    {
        string sql = "select Id, FirstName, LastName from People where Id = @Id";
        FullPersonModel output = new FullPersonModel();

        output.PersonInfo = db.LoadData<PersonModel, dynamic>(sql,
            new { Id = id },
            _connectionString).FirstOrDefault();

        if (output.PersonInfo == null)
        {
            return null;
        }

        // personmodel.addresses
        sql = @"select a.* 
                from Addresses a 
                inner join PeopleAddresses pa on pa.AddressId = a.Id
                where pa.PersonId = @Id";

        output.Addresses = db.LoadData<AddressModel, dynamic>(sql, new { Id = id }, _connectionString);

        // personmodel.employers
        sql = @"select e.*
                from Employers e
                inner join PeopleEmployers pe on pe.EmployerId = e.Id
                where pe.PersonId = @Id";

        output.Employers = db.LoadData<EmployerModel, dynamic>(sql, new { Id = id }, _connectionString);

        return output;
    }
}
