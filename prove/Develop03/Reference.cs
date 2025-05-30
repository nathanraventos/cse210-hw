using System.Data;

public class Reference
{
    private string _reference;

    private List<Scripture> _scriptures;

    public Reference(string reference, string verseText)
    {
        _reference = reference;
    }


    public void Display()
    {
        Console.WriteLine(_reference);
    }
}