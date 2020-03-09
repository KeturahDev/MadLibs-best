using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    [Route("/story")]
    public ActionResult Story(string name, string animal, string bathroomTask, string reflectiveObject)
    {
      StoryVariables myStoryVariables = new StoryVariables();
      myStoryVariables.Name = name;
      myStoryVariables.Animal = animal;
      myStoryVariables.BathroomTask = bathroomTask;
      myStoryVariables.ReflectiveObject = reflectiveObject;
      return View(myStoryVariables);   
      }
  }
}