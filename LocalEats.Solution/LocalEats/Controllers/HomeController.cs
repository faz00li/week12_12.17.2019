using Microsoft.AspNetCore.Mvc;

namespace LocalEats.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Title = "Welcome To Local Eats";
      
      return View();
    }

  }
}
