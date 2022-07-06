namespace NoteTaker;

public class NoteFile
{
    private static string _filePath = "";

    public static string FilePath
    {
        get { return _filePath; }
        set
        {
            if (value.Length > 0)
            {
                if (File.Exists(value) && value.Substring(value.Length-4, 4).CompareTo(".csv")==0)
                    _filePath = value;
                else
                {
                    Console.WriteLine(
                        "This system only works with csv files. Please ensure that the location of the file and file type are correct.");
                    _filePath = "N/A";
                }
            }
        }
    }

    private List<string> _allNotes = new();

    public List<string> AllNotes
    {
        get { return _allNotes;}
        set { _allNotes = NoteFile.ReadFile.Notes(); }
    }

    public static class ReadFile
    {
        public static List<string> Notes()
        {
            List<string> noteList = new();
            if (File.Exists(FilePath))
            {
                var allNotes = File.ReadAllLines(FilePath);
                foreach (var note in allNotes)
                {
                    noteList.Add(note);
                }
            }
            else
            Console.WriteLine("There was an error locating the file, please check and try again");
            return noteList;
        }
    }
    private class WriteFile
    {
        
    }
}