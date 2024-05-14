public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        // Split up the words in text and store each as a word object in the list _words
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden() == true)
            {
                _words[randomIndex].Hide();
            }
        }    
    }

    public string GetDisplayText()
    {
        string displayText = " ";
        foreach(Word word in _words)
        {   
          displayText = displayText + " " + word.GetDisplayText();            
        }
        return _reference.GetDisplayText() + " " + displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}