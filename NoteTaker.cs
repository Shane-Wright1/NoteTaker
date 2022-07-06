// See https://aka.ms/new-console-template for more information

using NoteTaker;

Console.WriteLine("\tNotes\n\nPress enter to start");
_=Console.ReadLine();
Note test = new("test","testing");
Note note2 = new("test2", "testing2");
Console.WriteLine($"{test.Heading}\n{test.Content}\n{test.Index}\n\n\n{note2.Heading}\n{note2.Content}\n{note2.Index}");

NoteFile.FilePath = @"C:\Users\shane\test.csv";
Console.WriteLine(NoteFile.FilePath);

List<string> notes = NoteFile.ReadFile.Notes();
int count = 1;

if (notes.Count > 0)
{
    foreach (String note in notes)
    {
        Console.WriteLine(note);
        if (count%3==0)
            Console.WriteLine("\n--------------------\n");
        count++;
    }
}
else
    Console.WriteLine("No Notes Found");