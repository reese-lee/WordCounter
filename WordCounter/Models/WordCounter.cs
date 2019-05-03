using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _wordOccurences;

    public RepeatCounter(string word, string sentence)
    {
      _word = word.ToLower();
      _sentence = sentence;
      GetResult();
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SearchForWord(string sentence)
    {
      string[] userArray = sentence.ToLower().Split(' ');

      foreach (string word in userArray)
      {
        if(word == _word || word == _word + "s")
        {
          _wordOccurences ++;
        }
      }
    }

    public int GetResult()
    {
      return _wordOccurences;
    }

  }
}
