using Microsoft.AspNetCore.Mvc;
using System;

using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Console.WriteLine("DEBUG: `/` visited");
      return View();
    }

    [Route("/MadLib")]
    public ActionResult MadLib(string noun, string adjective, string bodyparts, string noun2)
    {
      MadLibsVariables ml = new MadLibsVariables();
      ml.Noun = noun;
      ml.Noun2 = noun2;
      ml.Adjective = adjective;
      ml.BodyParts = bodyparts;
      Console.WriteLine("DEBUG: `/MadLib` visited");
      return View(ml);
    }
    

  }
}