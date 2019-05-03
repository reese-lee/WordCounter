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
    public void  RepeatCounterConstructor_CreatesInstanceOfObject_Strings()
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
    public void SearchForWordInLowerCase_SearchSentenceForWord_Int()
    {
      string word = "jelly";
      string sentence = "This jellyfish makes me jelly";
      RepeatCounter userCounter = new RepeatCounter(word);
      userCounter.SearchForWord(sentence);
      int wordOccurences = userCounter.GetResult();
      Assert.AreEqual(1, wordOccurences);
    }

    [TestMethod]
    public void SearchForWord_SearchSentenceForWordInLowerCase_Int()
    {
      string word = "jelly";
      string sentence = "This peanut butter and JELLY sandwich makes me jelly";
      RepeatCounter userCounter = new RepeatCounter(word);
      userCounter.SearchForWord(sentence);
      int wordOccurences = userCounter.GetResult();
      Assert.AreEqual(2, wordOccurences);
    }

    [TestMethod]
    public void SearchForWord_SearchSentenceForPluralsOfWord_Int()
    {
      string word = "jelly";
      string sentence = "This jellyfish JELLYS and jelly makes me jelly";
      RepeatCounter userCounter = new RepeatCounter(word);
      userCounter.SearchForWord(sentence);
      int wordOccurences = userCounter.GetResult();
      Assert.AreEqual(3, wordOccurences);
    }

    // Test for complex plurals (puppies = puppy), return to make it work
    // [TestMethod]
    // public void SearchForWord_SearchSentenceForComplexPluralsOfWord_Int()
    // {
    //   string word = "jelly";
    //   string sentence = "These jellies are jelly";
    //   RepeatCounter userCounter = new RepeatCounter(word);
    //   userCounter.SearchForWord(sentence);
    //   int wordOccurences = userCounter.GetResult();
    //   Assert.AreEqual(2, wordOccurences);
    // }
  }
}
