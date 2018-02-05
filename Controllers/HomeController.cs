using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/mad_lib")]
    public ActionResult MadLib()
    {
      WordVariables wordVariable = new WordVariables();
      wordVariable.SetName(Request.Query["name"]);
      wordVariable.SetAdverb(Request.Query["adverb"]);
      wordVariable.SetNouns(Request.Query["nouns"]);
      wordVariable.SetVehicle(Request.Query["vehicle"]);
      wordVariable.SetAnimal(Request.Query["animal"]);
      wordVariable.SetNouns2(Request.Query["nouns2"]);
      return View("mad_lib", wordVariable);
    }
  }
}
