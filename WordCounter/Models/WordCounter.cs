using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
      private string inputWord;
      private string newSentence;
      private int wordCount = 0;
      // private static List<RepeatCounter> Instances = new List<RepeatCounter>{};

      public RepeatCounter(string enterWord, string enterSentence)
      {
        inputWord = enterWord;
        newSentence = enterSentence;
      }
      public string GetWord()
      {
        return inputWord;
      }
      public string GetSentence()
      {
        return newSentence;
      }
      public int GetCount()
      {
        return wordCount;
      }
      public void CountWord()
      {
        string[] ArrayOfWords = newSentence.Split(' ', '.', ',', '!', '?');
        for(int i = 0; i < ArrayOfWords.Length; i++)
        {
          if(String.Equals(inputWord, ArrayOfWords[i]))
          {
            wordCount++;
          }
        }
      }
      // public static List<RepeatCounter> GetAll()
      // {
      //   return Instances;
      // }
      // public void Save()
      // {
      //   Instances.Add(this);
      // }
    }

    // public class Program
    // {
    //   public static void Main()
    //   {
    //     Console.WriteLine("Enter Your Word.");
    //     string firstWord = Console.ReadLine();
    //     RepeatCounter wordCount = new RepeatCounter(firstWord);
    //     Console.WriteLine("Enter Your Sentence.");
    //     string enterSentence = Console.ReadLine();
    //     int wordSum = wordCount.CountWord(enterSentence);
    //     Console.WriteLine("Your Word Appears " + wordSum);
    //     Console.WriteLine("Would You Like To Restart: Y/N");
    //     string restartGame = Console.ReadLine();
    //     if(restartGame.Equals("Y"))
    //     {
    //       Main();
    //     }
    //   }
    // }

}
