using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class NewCounterController : Controller
    {

        [HttpGet("/newcounter")]
        public ActionResult ReturnForm()
        {
          return View();
        }
        [HttpPost("/newcounter")]
        public ActionResult ReturnForm(string newWord, string newSentence)
        {
        RepeatCounter wordCount = new RepeatCounter(newWord, newSentence);
        wordCount.CountWord();
          return View(wordCount);
        }

        [HttpGet("/newcounter/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
