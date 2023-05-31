namespace hw_MethodOverloading;

internal class Program
{
    static void Main(string[] args)
    {
        List<EmployeeModel> employees = new List<EmployeeModel>();

        var employee1 = new EmployeeModel("John", "Tekulve", "Accountant");
        var employee2 = new EmployeeModel("John", "Humbach", "Barback");
        var employee3 = new EmployeeModel("John", "Casnellie", "Tree Climber");

        

        employees.Add(employee1);
        employees.Add(employee2);
        employees.Add(employee3);

        foreach (var employee in employees)
        { 
            Console.WriteLine($"{employee.LastName}, {employee.FirstName}. {employee.JobTitle}");
            Console.WriteLine($"Starting pay: {employee.StartingPay}");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

public class EmployeeModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string JobTitle { get; set; }
    public int StartingPay { get; set; }

    public EmployeeModel()
    {
        
    }

    public EmployeeModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public EmployeeModel(string firstName, string lastName, string jobTitle)
    {
        FirstName = firstName;
        LastName = lastName;
        JobTitle = jobTitle;
    }
    public EmployeeModel(string firstName, string lastName, string jobTitle, int startingPay)
    {
        FirstName = firstName;
        LastName = lastName;
        JobTitle = jobTitle;
        StartingPay = startingPay;
    }


}