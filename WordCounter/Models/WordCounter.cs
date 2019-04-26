using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private int _wordOccurences;

    public RepeatCounter(string userInput)
    {
      _word = userInput.ToLower();
    }

    public string GetWord()
    {
      return _word.ToLower();
    }

    public int GetResult()
    {
      return _wordOccurences;
    }

    public int SearchForWord(string userSentence)
    {
      string sentence = userSentence.ToLower();
      string[] userArray = sentence.Split(' ');

      foreach (string word in userArray)
      {
        if(word == _word || word == _word + "s")
        {
          _wordOccurences ++;
        }
      }
      return _wordOccurences;
    }

    // public void SetSearchWord(string newWord)
    // {
    //   _word = newWord.ToLower();
    // }

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
