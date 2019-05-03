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
      // string userWord;
      // RepeatCounter newWord = new RepeatCounter(userWord);
      // string
      return View("Index");
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string description)
    {
      // RepeatCounter newWord = new RepeatCounter();
      return RedirectToAction("Index");
    }

  }
}
