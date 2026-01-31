using System;

class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        _words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
    }

    public string GetText()
    {
        string scriptureText = _reference.GetReference() + " ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetText() + " ";
        }
        return scriptureText.Trim();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        while (hiddenCount < count)
        {
            int index = rand.Next(_words.Length);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
        if (count <= 0) return;
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}