namespace NoteTaker;

public class Note
{
    
    //instance variables for heading, content and index of a note.
    private string _heading = "";
    private string _content = @"";
    private int index;

    public string Heading
    {
        get { return _heading; }
        set
        {
            if (value.CompareTo("") != 0)
                _heading = value;
        }
    }

    public string Content
    {
        get { return _content; }
        set
        {
            if (value.CompareTo("") != 0)
                _content = value;
        }
    }

    public int Index
    {
        get { return index; }
    }

}