using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/WordCounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/WordCounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/WordCounter")]
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter newWord = new RepeatCounter(word, sentence);
      newWord.SearchForWord(sentence);
      return View("Index", newWord);
    }

  }
}
