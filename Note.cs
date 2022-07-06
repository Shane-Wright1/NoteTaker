namespace NoteTaker;

public class Note
{
    
    //instance variables for heading, content and index of a note.
    private string _heading = "";
    private string _content = @"";
    private static int _nextIndex = 0;

    public Note(string heading, string content, int index)
    {
        Heading = heading;
        Content = content;
        Index = index;
    }
    
    public Note(string heading, string content)
    {
        Heading = heading;
        Content = content;
        Index = _nextIndex;
        _nextIndex += 1;
    }
    public string Heading
    {
        get => _heading;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _heading = value;
            else
                _heading = "< >";
        }
    }

    public string Content
    {
        get => _content;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _content = value;
            else
                _content = "< >";
        }
    }

    public int Index { get; }
}