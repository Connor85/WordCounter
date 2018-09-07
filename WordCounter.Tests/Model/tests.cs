using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounterModels;


  [TestClass]
  public class WordCheckerTest
  {
    [TestMethod]
    public void ReturnString_ReturnsAString_ReturnsReturnString ()
    {
    RepeatCounter check = new RepeatCounter();
    string phrase = "pizza";
    check.SetString(phrase);
    string result = check.GetString();
    Assert.AreEqual(phrase, result);
    }
    [TestMethod]
    public void Returnphrase_ReturnsAPhrase_ReturnsReturnPhrase ()
    {
    RepeatCounter check = new RepeatCounter();
    string phrase = "I like to eat pizza";
    check.SetSentence(phrase);
    string result = check.GetSentence();
    Assert.AreEqual(phrase, result);
    }
    [TestMethod]
    public void ReturnsCount_ReturnsACount_ReturnsReturnCount ()
    {
      RepeatCounter check = new RepeatCounter();
      string word = "pizza";
      string splitPhrase = "pizza pizza pizza";

      check.SetString(word);
      check.SetSentence(splitPhrase);
      int matches = RepeatCounter.Main();

      Assert.AreEqual(3, matches);
    }
}
