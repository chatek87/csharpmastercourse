// create console app that asks user for their name
// welcome the name Tim as prof and anyone else as student
// keep prompting for name until user enters 'exit'

string name;
bool hasExited = false;

while (hasExited == false) 
{
    Console.Write("Please enter your name: ");
    name = Console.ReadLine();
    
    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Greetings, Professor {name}");
    }
    else if (name.ToLower() == "exit")
    {
        hasExited = true;
    }
    else
    {
        Console.WriteLine($"Hello, {name}");
    }
}


