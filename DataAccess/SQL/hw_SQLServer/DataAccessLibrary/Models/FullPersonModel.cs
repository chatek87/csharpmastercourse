using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models;

public class FullPersonModel
{
    public PersonModel PersonInfo { get; set; }
    public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    public List<EmployerModel> Employers { get; set; } = new List<EmployerModel>();
}
