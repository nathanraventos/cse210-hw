using System.Data;

public class Scripture
{
    private Word[] _words;
    private Reference _reference;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        _words = new Word[splitWords.Length];

        for (int i = 0; i < splitWords.Length; i++)
        {
            _words[i] = new Word(splitWords[i]);
        }

    }

    public void Display()
    {
        _reference.Display();
        foreach (Word word in _words)
        {
            Console.WriteLine(word.Display()+ )
        }
    }






}