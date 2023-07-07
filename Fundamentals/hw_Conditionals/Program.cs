// ask user for their name
Console.Write("What's yer name? ");
string name = Console.ReadLine();

// welcome Tim as prof and anyone else as student
// make sure Tim gets called professor
if (name.ToLower() == "tim")
{
    Console.WriteLine($"Welcome, glorious Professor {name}!");
}
else
{
    Console.WriteLine($"Welcome, lowly student {name}!");
}
Console.ReadKey();