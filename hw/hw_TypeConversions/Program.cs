// capture user's age from console
int age = 0;
bool isNum = false;

while (isNum == false)
{
    Console.Write("Enter your age: ");
    string? input = Console.ReadLine();
    isNum = int.TryParse(input, out age);
}

Console.WriteLine($"Your age: {age}");

Console.WriteLine($"In 25 years, you will be {age + 25} years old.");


if (age >= 25)
{
    Console.WriteLine($"25 years ago, you were {age - 25} years old.");
}
else
{
    Console.WriteLine($"25 years ago, you were just a glimmer in your daddy's eye!");
}

Console.ReadKey();
// then identify how old they will be in 25 years, as well as how old they were 25 years ago

// print that info to the console in natural language