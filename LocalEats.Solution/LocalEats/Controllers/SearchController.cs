using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalEats.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalEats.Controllers
{
  public class SearchesController : Controller
  {
    private readonly LocalEatsContext _db;

    public SearchesController(LocalEatsContext db)
    {
      _db = db;
    }

    public ActionResult Search()
    {
      ViewBag.Title = "Search";
      return View();
    }

    [HttpPost]
    public ActionResult SearchResult(Cafe searchCafe)
    {
      Cafe thisCafe = _db.Cafes.FirstOrDefault(cafe => cafe.CafeName == searchCafe.CafeName);
      return View(thisCafe);
    }
  }
}
