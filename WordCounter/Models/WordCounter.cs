// using System;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    // private string _sentence;
    // private int _result;

    public RepeatCounter(string userInput)
    {
      _word = userInput.ToLower();
    }

    public string GetWord()
    {
      return _word.ToLower();
    }

    // public int GetResult()
    // {
    //   return _result;
    // }

    public void SetSearchWord(string newWord)
    {
      _word = newWord.ToLower();
    }

    // public int CheckWords()
    // {
    //   string userWord = word;
    //   char[] userArray = userWord.ToCharArray();
    //   for (index i = 0; i < userArray.Count; i++)
    //   {
    //
    //   }
    // }



  }
}
