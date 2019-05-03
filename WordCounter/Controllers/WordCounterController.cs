using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index(string word)
    {
      RepeatCounter newWord = new RepeatCounter(word);
      // string
      return View("Index");
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter/new")]
    public ActionResult Create(string description)
    {
      RepeatCounter newWord = new RepeatCounter();
      return RedirectToAction("Index");
    }

  }
}
