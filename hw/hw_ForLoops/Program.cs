

// ask the user for a comma-separated list of first names (no spaces) 
// split the string into a string array
// loop through the array and print "Hello, (name)" to the console for each person
// 

Console.WriteLine("Enter a bunch of first names separated by commas (no spaces please)!");
var input = Console.ReadLine();
string[] names = input.Split(',');
Console.WriteLine();

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello, {names[i]}");
}

Console.ReadKey();


/*string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}*/