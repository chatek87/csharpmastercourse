using hw_ClassLibrary;

namespace hw_ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 4;

        Console.WriteLine(Calculator.Add(a, b));

        Console.ReadLine();
    }
}
 