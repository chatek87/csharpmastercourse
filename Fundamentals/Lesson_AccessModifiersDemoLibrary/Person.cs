namespace Lesson_AccessModifiersDemoLibrary;

public class DataAccess
{
	protected internal string GetConnectionString()
	{
		return "Sensitive data";
	}
}

public class Person
{
	protected string formerLastName = "";
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private string _ssn;

	public string SSN
	{
		get 
		{ 
			return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
		}
		set
		{
			_ssn = value; 
		}
	}

	public void ChangeLastName(string newLastName)
	{
		formerLastName = LastName;
		LastName = newLastName;
	}

	public void SayHello()
    {
        Console.WriteLine($"Hello {FirstName}");
    }

	public void SavePerson()
	{
		// saves the person

		DataAccess data = new DataAccess();
		
		string conn = data.GetConnectionString();
	}
}

public class Employee : Person
{
	public string GetFormerLastName()
	{
		return formerLastName;
	}
}

public class Manager : Employee
{
	public string GetAllNames()
	{
		return $"{FirstName} {LastName} {formerLastName}";
	}
}