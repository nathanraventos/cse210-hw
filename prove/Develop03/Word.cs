

public class Word
{
    private string _word;

    private string _hidden;

    private bool _isVisible;


    public Word(string word)
    {
        _word = word;
        _hidden = new string('_', word.Length);
        _isVisible = true;
    }

    public void Hide()
    {
        _isVisible = false;
    }

    public bool IsVisible()
    {
        return _isVisible;
    }

    public string Display()
    {
        return _isVisible ? _word : _hidden;
    }

    public void Reveal()
    {
        _isVisible = true;
    }
}




