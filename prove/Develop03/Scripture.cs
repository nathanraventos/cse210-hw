

public class Scripture
{
    private Word[] _words;
    private Reference _reference;
    private static Random random = new Random();

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
        int wordCount = 0;

        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
            wordCount++;

            if (wordCount % 15 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("\n");
    }

    public void HideSome(int numberToHide)
    {
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Length; i++)
        {
            if (_words[i].IsVisible())
            {
                visibleIndices.Add(i);
            }
        }

        if (visibleIndices.Count > 0)
        {
            int hideCount = Math.Min(numberToHide, visibleIndices.Count);
            for (int i = 0; i < hideCount; i++)
            {
                int indexToHide = visibleIndices[random.Next(visibleIndices.Count)];
                _words[indexToHide].Hide();
                visibleIndices.Remove(indexToHide);
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsVisible())
            {
                return false;
            }
        }
        return true;
    }
    public void Reset()
    {
        foreach (Word word in _words)
        {
            word.Reveal();
        }
    }



}