namespace hw_WrapUpDemo;

internal class Program
{
    static void Main(string[] args)
    {
        List<InstrumentModel> instruments = new List<InstrumentModel>
        {
            new InstrumentModel { InstrumentName = "Xylophone", InstrumentType = InstrumentType.Percussion},
            new InstrumentModel { InstrumentName = "Viola", InstrumentType = InstrumentType.Stringed},
            new InstrumentModel { InstrumentName = "Trombone", InstrumentType = InstrumentType.Brass},
            new InstrumentModel { InstrumentName = "Cor Anglais", InstrumentType = InstrumentType.Woodwind},
            new InstrumentModel { InstrumentName = "Bass, Soloist", InstrumentType = InstrumentType.Voice},
            new InstrumentModel { InstrumentName = "Harpsichord", InstrumentType = InstrumentType.Keyboard}
        };

        List<MusicalPieceModel> musicalPieces = new List<MusicalPieceModel>
        {
            new MusicalPieceModel {Title = "Hamburgers On A Tuesday", Composer = "Charlie Tekulve", LengthInMinutes = 5},
            new MusicalPieceModel {Title = "The Adventurous Frommage", Composer = "Bill Buttlicker", LengthInMinutes= 33},
            new MusicalPieceModel {Title = "I'm Sorry, Bill.", Composer = "Bob Buttlicker", LengthInMinutes= 2}
        };

        DataAccess<InstrumentModel> instrumentData = new DataAccess<InstrumentModel>();
        instrumentData.BadValueFound += InstrumentData_BadValueFound;
        instrumentData.SaveToCSV(instruments, @"C:\temp\SavedFiles\instruments.csv");

        DataAccess<MusicalPieceModel> musicalPieceData = new DataAccess<MusicalPieceModel>();
        musicalPieceData.BadValueFound += MusicalPieceData_BadValueFound;
        musicalPieceData.SaveToCSV(musicalPieces, @"C:\temp\SavedFiles\musicalpieces.csv");


        Console.ReadKey(true);
    }

    private static void MusicalPieceData_BadValueFound(object? sender, MusicalPieceModel e)
    {
        Console.WriteLine($"Sorry, no pieces by composers named Bill.");
    }

    private static void InstrumentData_BadValueFound(object? sender, InstrumentModel e)
    {
        Console.WriteLine($"Sorry, no woodwinds allowed.");
    }
}
// for demo purposes, we are going to save instruments and pieces collections to CSV
// we are going to check for any woodwinds, and not allow them to be saved to CSV
// we are also going to allow pieces by anyone named "Bill" to be saved
// instead, we are going to alert user when forbidden values have been attempted to be added


public class DataAccess<T> where T : new()
{
    public event EventHandler<T> BadValueFound;
    public void SaveToCSV(List<T> items, string filePath)
    {

        List<string> rows = new List<string>();
        T entry = new T();                              // we are instantiating a new object of type T so that we can use reflection to get the type and properties in the next line
        var cols = entry.GetType().GetProperties();     // here, var type is: System.Reflection.PropertyInfo[]

        string row = "";                                // starting with empty string
        foreach (var col in cols)                       // printing the header row
        {
            row += $",{col.Name}";                      // adding the name of each property in the object to the header row
        }
        row = row.Substring(1);                         // chopping off the first comma
        rows.Add(row);

        foreach (var item in items)
        {
            row = "";
            bool badValueDetected = false;

            foreach (var col in cols)
            {
                string val = col.GetValue(item, null).ToString();
                string propertyName = col.Name;
                
                badValueDetected = BadValueDetector(val, propertyName);
                if (badValueDetected == true)
                {
                    BadValueFound?.Invoke(this, item);
                    break;
                }

                row += $",{val}";
            }
        
            if (badValueDetected == false)
            {
                row = row.Substring(1);
                rows.Add(row);
            }
        }


        File.WriteAllLines(filePath, rows);
    }

    private bool BadValueDetector(string valueToCheck, string propertyName)
    {
        bool output = false;
        string lowerCaseValue = valueToCheck.ToLower();
        string lowerCasePropertyName = propertyName.ToLower();

        if (lowerCaseValue.Contains("bill") && lowerCasePropertyName == "composer")
        {
            output = true;
        }

        if (lowerCaseValue.Contains("woodwind") && lowerCasePropertyName == "instrumenttype")
        {
            output = true;
        }

        return output;
    }
}

public class MusicalPieceModel
{
    public string Composer { get; set; }
    public string Title { get; set; }
    public int LengthInMinutes { get; set; }
}

public class InstrumentModel
{
    public string InstrumentName { get; set; }
    public InstrumentType InstrumentType { get; set; }
}

public enum InstrumentType
{
    Percussion,
    Stringed,
    Brass,
    Woodwind,
    Voice,
    Keyboard
}