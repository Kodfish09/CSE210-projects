using System;

public class Scripture() 
{
    private Reference _reff;
    private List<Word> _words = new List<Word>();

    public Reference GetReference()
    {
        return _reff;
    }
    public List<Word> GetWords ()
    {
        return _words;
    }

    public void SetReference(Reference reff)
    {
        _reff = reff;
    }

    public void SetWords(List<Word> words)
    {
        _words = words;
    }

    public void removeWord()
    {
        bool found = false;
        while (found == false) {
            int random = new Random().Next(0,_words.Count);
            if (_words[random].GetWord() != "_____") {
                _words[random].SetWord("_____");
                found = true;
            }
        }
    }

    public int CountWords ()
    {
        int num = 0;
        foreach (Word w in _words)
        {
            if (w.GetWord() != "_____") 
            {
                num += 1;
            }
        }
        return num;
    }
}