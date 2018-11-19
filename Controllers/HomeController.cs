using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLeter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/Journal")]
    public ActionResult Journal()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Lina");
      myLetterVariable.SetSender("Jake");
      return View(myLetterVariable);
    }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend";}

    [Route("/")]
    public ActionResult Letter()
    {
      return View();
    }

  }
}
