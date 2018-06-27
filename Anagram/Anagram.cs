using System;
using System.Text;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramChecker
  {
    private string AnagramWord;

    public AnagramChecker(string word = "")
    {
      AnagramWord = word;
    }
    public string GetWord()
    {
      return AnagramWord;
    }
    public string FindAnagram(string wordString)
    {
      string[] words = wordString.Split(' ');

      List<string> anagramWords = new List<string> {};
      foreach (string word in words)
      {
        if(word.Length <= AnagramWord.Length)
        {
          string testWord = word;
          string myWord = AnagramWord;
          for(int i = 0; i < testWord.Length; i++)
          {
            int position = myWord.IndexOf(testWord[i]);
            if(position > -1)
            {
              testWord = testWord.Remove(i,1);
              myWord = myWord.Remove(position,1);
              i--;
            }
          }
          if(testWord.Length == 0)
          {
            anagramWords.Add(word);
          }
        }
      }
      return String.Join(", ", anagramWords.ToArray());
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word:");
      string word = Console.ReadLine();
      AnagramChecker myWord = new AnagramChecker(word);
      Console.WriteLine("Enter a list of possible anagram words separate by space:");
      string wordString = Console.ReadLine();
      string result = myWord.FindAnagram(wordString);
      if(result.Length > 0)
      {
        Console.WriteLine("\'" + result + "\' are anagrams of " + myWord.GetWord());
      }
      else
      {
        Console.WriteLine("None of the words are anagrams of " + myWord.GetWord());
      }
    }
  }
}
