

// add students to a class roster list until there are no more students to add (ur choice how that works)
// print the count of the students to the console

/*
 * make the list
 * prompt user to enter first student name
 * after name is entered, prompt user whether to enter another or finished
 * if finished, print count of list
 */


List<string> students = new();

bool finishedAdding = false;
while (!finishedAdding)
{
    Console.Write("Enter a student's name to add to the class roster: ");
    students.Add(Console.ReadLine());

    Console.Write("Add another student? (yes/no): ");
    var answer = Console.ReadLine();
    if (answer.ToLower() != "y" && answer.ToLower() != "yes")
    {
        finishedAdding = true;
    }
}
Console.WriteLine($"{students.Count}");
Console.ReadLine();