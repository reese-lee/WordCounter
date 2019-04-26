using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private int _wordOccurences;

    public RepeatCounter(string word)
    {
      _word = word.ToLower();
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
        else if (word == _word + "ies")
        {
          _wordOccurences ++;
        }
      }
      return _wordOccurences;
    }

  }
}
