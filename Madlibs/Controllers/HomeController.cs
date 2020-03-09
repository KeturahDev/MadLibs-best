using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult StoryDirectory() { return View(); }

    [Route("/story-form")]
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
    [Route("/epicodus-story-form")]
    public ActionResult EpicodusStoryForm() { return View(); }

    [Route("/epicodus-story")]
    public ActionResult EpicodusStory (string weirdName, string codingCatastrophy, string timeOfYear, string programmingLang, string studentName, string hobby)
    {
      EpicodusStoryVariables myVariables = new EpicodusStoryVariables();
      myVariables.WeirdName = weirdName;
      myVariables.CodingCatastrophy = codingCatastrophy;
      myVariables.TimeOfYear = timeOfYear;
      myVariables.ProgrammingLang = programmingLang;
      myVariables.StudentName = studentName;
      myVariables.Hobby = hobby;
      return View(myVariables);
    } 
  }
}
  

  