using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/game")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
