
// create a dictionary list of employee ids and the name that goes with the id
// fill in a few records
// then ask the user for their id and return their name

Dictionary<string, string> employees = new()
{
    { "1", "Chaach McGaach" },
    { "2", "Cheech McGeech" },
    { "3", "Chiich McGiich" },
    { "4", "Chooch McGooch" },
    { "5", "Chuuch McGuuch" }
};

Console.Write($"Enter your ID: ");
var id = Console.ReadLine();

if (employees.ContainsKey(id))
{
    Console.WriteLine(employees[id]);
}
else
{
    Console.WriteLine($"Sorry, no record of an employee with an ID of {id}");
}


Console.ReadKey();
