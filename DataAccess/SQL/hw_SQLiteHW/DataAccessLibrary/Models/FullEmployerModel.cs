using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models;

public class FullEmployerModel
{
    public EmployerModel EmployerInfo { get; set; }
    public List<PersonModel> Employees { get; set; } = new List<PersonModel>();
    public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
}
