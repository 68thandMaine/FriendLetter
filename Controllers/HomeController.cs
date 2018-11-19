using Microsoft.AspNetCore.Mvc;

namespace FriendLeter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!";}

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend";}

    [Produces("text/html")]
    [Route("/")]
    public string Letter()
    {
      return
      "<!DOCTYPE html>" +
      "<html>" +
      "<head>" +
        "<title>Hello Friend!</title>" +
        "<link rel='stylesheet' href='https://maxcdn.bootstrap.cdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
      "</head>" +
      "<body>" +
        "<h1>Hello From Afar</h1>" +
        "<p>Dear Josh,</p>" +
        "<p>How are you? I hope that you are having a nice weekend! I am learning programming while in Iceland! </p>" +
        "<p>Josh, you would not believe how cold it is here. I probably should have gone to Hawaii instead </p>" +
        "<p>But I like programming a lot, so I've got that going for me. </p>" +
        "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
        "<p>Cheers,</p>" +
        "<p>Travel Enthusiast Chris</p>" +
        "</body>" +
        "</html>";
    }
  }
}
