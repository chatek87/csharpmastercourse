using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDataAccessLibrary.Models;

public class EmployerModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string EmployerName { get; set; }
    public AddressModel Address { get; set; } = new AddressModel();
    public List<PersonModel> Employees { get; set; } = new List<PersonModel>(); 
}
