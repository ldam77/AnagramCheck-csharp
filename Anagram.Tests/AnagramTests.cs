using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramCheckerTest
  {
    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      string word = "bread";
      AnagramChecker newWord = new AnagramChecker(word);

      //Act
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void FindAnagram_ReturnsWordString_WordString()
    {
      //Arrange
      string word = "bread";
      string myString = "beard reads";
      string expected = "beard";
      AnagramChecker newWord = new AnagramChecker(word);

      //Act
      string result = newWord.FindAnagram(myString);

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
