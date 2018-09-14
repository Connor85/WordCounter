using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _phrase;
    private string _word;
    public int matches = 0;

    public RepeatCounter(string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
    }

    public void SetPhrase(string phrase)
    {
      _phrase = phrase;
    }
    public string GetPhrase()
    {
      return _phrase;
    }
    public void SetWord(string word)
    {
      _word = word;
    }
    public string GetWord()
    {
      return _word;
    }
    public string[] SplitString()
    {
      return _phrase.Split(' ');
    }
    public int WordCount()
    {
      foreach(string wordMatch in SplitString())
      {
        if(wordMatch.Equals(_word))
        {
          matches ++;
        }
      }
      return matches;
    }
  }
}
