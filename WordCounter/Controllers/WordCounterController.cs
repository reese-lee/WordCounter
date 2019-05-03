using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      string userWord;
      RepeatCounter newWord = new RepeatCounter(word);
      string userWord = newWord.GetWord();
      return View(userWord);
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string description)
    {
      RepeatCounter newWord = new RepeatCounter(word);
      return RedirectToAction("Index");
    }

  }
}
