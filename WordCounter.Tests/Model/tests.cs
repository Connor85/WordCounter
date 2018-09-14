using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void Return_ReturnsAPhrase_ReturnsReturnphrase()
    {
      string input = "pizza";
      RepeatCounter newCount = new RepeatCounter();

      newCount.SetPhrase(input);
      string result = newCount.GetPhrase();

      Assert.AreEqual(input, result);
    }
    [TestMethod]
    public void Return_SplitString_ReturnSplitString()
    {
      string inputString = "pizza pizza pizza";
      string[] inputArr = {"pizza", "pizza", "pizza"};
      RepeatCounter newCount = new RepeatCounter();

      newCount.SetPhrase(inputString);
      string[] result = newCount.SplitString();

      CollectionAssert.AreEqual(inputArr, result);
    }
    [TestMethod]
    public void Match_CountWordMatches()
    {
      string inputString = "pizza pizza large";
      string inputWord = "pizza";
      RepeatCounter newCount = new RepeatCounter();

      newCount.SetPhrase(inputString);
      newCount.SetWord(inputWord);
      int wordMatches = newCount.WordCount();

      Assert.AreEqual(2, wordMatches);
    }
  }
}
