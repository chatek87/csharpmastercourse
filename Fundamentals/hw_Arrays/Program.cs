

// create an array of 3 names
// ask the user which number to select
// when the user gives you a number, return that name
// make sure to check for invalid numbers

string[] names = { "bob", "james", "cassandra" };

int number = 0;
bool isNum = false;
while (isNum == false)
{
    Console.Write($"Pick a number, 1 through {names.Length}: ");
    isNum = int.TryParse(Console.ReadLine(), out number);
    if (number < 1 || number > names.Length)
    {
        isNum = false;
    }
}

//Console.WriteLine($"you entered {number}");
Console.WriteLine($"You selected {names[number - 1]}");

Console.ReadKey();