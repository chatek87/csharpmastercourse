// plan and build console app that asks user for name and age

Console.Write("What's yer name? ");
var name = Console.ReadLine();

var age = 0;
bool isNum = false;
while (isNum == false)
{
    Console.Write("How old are you? ");
    var input = Console.ReadLine();
    isNum = int.TryParse(input, out age);
}

if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    Console.WriteLine("Hello, Professor!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
if (age < 21)
{
    Console.WriteLine($"Sorry, see you in {21 - age} years");
}
/*if (age < 21)
{
    int i = 0;
    while (age < 21)
    {
        age++;
        i++;
    }
    if (i == 1)
    {
        Console.WriteLine($"Sorry, see you in {i} year!");
    }
    else
    {
        Console.WriteLine($"Sorry, see you in {i} years!");
    }
}*/

Console.ReadKey();
// if name is bob or sue, address them as prof
// if person is under 21, recommend they wait x years to start this class