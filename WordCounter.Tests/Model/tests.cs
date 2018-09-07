using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounterModels;


  [TestClass]
  public class WordCheckerTest
  {
    [TestMethod]
    public void ReturnString_ReturnsAString_ReturnsReturnString ()
    {
    WordCounter check = new WordCounter();
    string phrase = "pizza";
    check.SetString(phrase);
    string result = check.GetString();
    Assert.AreEqual(phrase, result);
    }
    [TestMethod]
    public void Returnphrase_ReturnsAPhrase_ReturnsReturnPhrase ()
    {
    WordCounter check = new WordCounter();
    string phrase = "I like to eat pizza";
    check.SetSentence(phrase);
    string result = check.GetSentence();
    Assert.AreEqual(phrase, result);
    }
}
