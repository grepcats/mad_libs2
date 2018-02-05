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
      return View("mad_lib", wordVariable);
    }
  }
}
