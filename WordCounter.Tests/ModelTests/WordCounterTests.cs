using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfObject_Strings()
    {
      RepeatCounter userCounter = new RepeatCounter("jelly");
      Assert.AreEqual(typeof(RepeatCounter), userCounter.GetType());
    }

    [TestMethod]
    public void ReturnUserWord_UserWordIsReturned_String()
    {
      string word = "jelly";
      RepeatCounter userCounter = new RepeatCounter("JELLY");
      string wordCheck = userCounter.GetWord();
      Assert.AreEqual(word, wordCheck);
    }

    [TestMethod]
    public void SearchForWord_SearchSentenceForWord_Int()
    {
      string word = "jelly";
      string sentence = "This makes me jelly";
      RepeatCounter userCounter = new RepeatCounter(word);
      userCounter.SearchForWord(sentence);
      int wordOccurences = userCounter.GetResult();
      Assert.AreEqual(1, wordOccurences);
    }

    // [TestMethod]
    // public void GetsSentence_ReturnsLetterCharactersOnly_String()
    // {
    //   RepeatCounter userCounter = new RepeatCounter("jelly", "The jelly beans are good");
    //   string userInput = "choco sta1ns";
    //   string lettersOnly = userCounter.GetLetters(userInput);
    //   Assert.AreEqual("choco", lettersOnly);
    // }

    // [TestMethod]
    // public void CheckWord_CheckIfWordRepeats_True()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void CheckWordOccurence_CheckNumberOfTimesWordAppears_Int()
    // {
    //
    // }

  }
}
