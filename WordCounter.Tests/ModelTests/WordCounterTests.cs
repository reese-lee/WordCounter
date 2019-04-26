using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void UserInput_CreatesInstanceOfWordandSentence_Strings()
    {
      RepeatCounter userCounter = new RepeatCounter("jelly", "The jelly beans are good");
      Assert.AreEqual(typeof(RepeatCounter), userCounter.GetType());
    }

  }
}
