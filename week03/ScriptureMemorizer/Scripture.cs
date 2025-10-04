using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference refe, string phrase)
    {
        _reference = refe;

        List<string> phraseWords = phrase.Split(" ").ToList();

        foreach (string w in phraseWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        int hideCount = Math.Min(numberToHide, visibleIndices.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int randomIndex = rand.Next(visibleIndices.Count);
            int wordIndex = visibleIndices[randomIndex];

            _words[wordIndex].Hide();
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string phrase = "";

        foreach (Word word in _words)
        {
            phrase += word.GetDisplayText() + " ";
        }

        return phrase.TrimEnd();
    }

    public bool IsCompletelyHidden()
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

    public Reference GetReference()
    {
        return _reference;
    }
}
