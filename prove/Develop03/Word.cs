public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // Should return the word if visible or return underscore ____ if hidden
        string underscore = "";
        if (_isHidden == true)
        {
            for(int i = 0; i < _text.Length; i++)
            {
                underscore += "_";
            }
            return underscore;
        }
        else
        {
            return _text;
        }
    }
}