namespace Lesson_Events;

internal class Program
{
    static void Main(string[] args)
    {
        CollegeCourseModel history = new CollegeCourseModel("History 101", 3);
        CollegeCourseModel music = new CollegeCourseModel("Ethnomusicological Survey of South Sudan", 2);

        history.EnrollmentFull += CollegeCourse_EnrollmentFull;

        history.SignUpStudent("Billy Joel").PrintString();
        history.SignUpStudent("Grant Achatz").PrintString();
        history.SignUpStudent("Jeremiah Bullfrog").PrintString();
        history.SignUpStudent("Peepaw").PrintString();
        history.SignUpStudent("Meemaw").PrintString();
        Console.WriteLine();

        music.EnrollmentFull += CollegeCourse_EnrollmentFull;

        music.SignUpStudent("Jeremiah Bullfrog").PrintString();
        music.SignUpStudent("Peepaw").PrintString();
        music.SignUpStudent("Meemaw").PrintString();

        Console.ReadLine();
    }

    private static void CollegeCourse_EnrollmentFull(object sender, string e)
    {
        CollegeCourseModel model = (CollegeCourseModel)sender;

        Console.WriteLine();
        Console.WriteLine($"{model.CourseTitle}: Full");
        Console.WriteLine();
    }

    /*private static void Music_EnrollmentFull(object? sender, string e)
    {
        Console.WriteLine();
        Console.WriteLine("The enrollment is full for music.");
        Console.WriteLine();
    }

    private static void History_EnrollmentFull(object? sender, string e)
    {
        Console.WriteLine();
        Console.WriteLine("The enrollment is full for history.");
        Console.WriteLine();
    }*/
}

public static class ConsoleHelper
{
    public static void PrintString(this string message)
    {
        Console.WriteLine(message);
    }
}

public class CollegeCourseModel
{
    public event EventHandler<string> EnrollmentFull;

    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingList = new List<string>();
    public string CourseTitle { get; private set; }
    public int MaxStudents { get; private set; }


    public CollegeCourseModel(string title, int maxStudents)
    {
        CourseTitle = title;
        MaxStudents = maxStudents;
    }

    public string SignUpStudent(string studentName)
    {
        string output = "";

        if (enrolledStudents.Count < MaxStudents)
        {

            enrolledStudents.Add(studentName);
            output = $"{studentName} was enrolled in {CourseTitle}.";

            if (enrolledStudents.Count == MaxStudents)
            {
                Console.WriteLine();
                EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
                Console.WriteLine();
            }
        }
        else
        {
            waitingList.Add(studentName);
            output = $"{studentName} added to Waiting List for {CourseTitle}.";
        }

        return output;
    }
}