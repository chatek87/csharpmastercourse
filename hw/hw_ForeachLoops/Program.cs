

// ask user for their first name
// continue asking until no more names
// loop thru each name and say hello

string answer; 
List<string> names = new();

do
{
    Console.Write("enter a first name: ");
    names.Add(Console.ReadLine());

    Console.Write("Finished? (yes/no): ");
    answer = Console.ReadLine();
} while (answer.ToLower() != "yes" && answer.ToLower() != "y");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.ReadKey();