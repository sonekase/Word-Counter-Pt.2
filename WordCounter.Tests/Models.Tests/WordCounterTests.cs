using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetWord_ReturnWord()
    {
      //Arrange
      string firstWord = "salmon";
      string enterSentence = "salmon";
      RepeatCounter wordCount = new RepeatCounter(firstWord, enterSentence);
      //Act
      string expectedResult = wordCount.GetWord();
      //Assert
      Assert.AreEqual(firstWord, expectedResult);
    }
    [TestMethod]
    public void CountWord()
    {
      //Arrange
      string firstWord = "Salmon";
      string enterSentence = "Salmon";
      int outPut = 1;
      RepeatCounter wordCount = new RepeatCounter(firstWord, enterSentence);
      //Act
      wordCount.CountWord();
      //Assert
      Assert.AreEqual(outPut, wordCount.GetCount());
    }
    [TestMethod]
    public void CountWord2()
    {
      //Arrange
      string firstWord = "Pig";
      string enterSentence = "Two little Pig Pig in the barn";
      int outPut = 2;
      RepeatCounter wordCount = new RepeatCounter(firstWord, enterSentence);
      //Act
      wordCount.CountWord();
      //Assert
      Assert.AreEqual(outPut, wordCount.GetCount());
    }
    [TestMethod]
    public void CountWord3()
    {
      //Arrange
      string firstWord = "Fish";
      string enterSentence = "Fish Fish Fish in the sea Fishery";
      int outPut = 3;
      RepeatCounter wordCount = new RepeatCounter(firstWord, enterSentence);
      //Act
      wordCount.CountWord();
      //Assert
      Assert.AreEqual(outPut, wordCount.GetCount());
    }
  }
}
