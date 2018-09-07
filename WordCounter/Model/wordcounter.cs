using System.Collections.Generic;
using System;

namespace WordCounterModels
{
  public class WordCounter
  {
    private string _word;
    public string GetString()
    {
      return _word;
    }

    public void SetString(string word)
    {
      _word = word;
    }
    private string _phrase ="I like to eat pizza";
    public string GetSentence()
    {
      return _phrase;
    }
    public void SetSentence(string phrase)
    {
      _phrase = phrase;
    }

    public static void Main()
    {
      Console.WriteLine("Please enter a word");
      string word = Console.ReadLine();

      Console.WriteLine("Please enter a sentence");
      string phrase = Console.ReadLine();
      string[] splitPhrase = phrase.Split(' ');
      foreach (var value in splitPhrase)
    }
  }
}
