using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalEats.Models;
using System.Collections.Generic;
using System.Linq;


namespace LocalEats.Controllers
{
  public class CafesController : Controller
  {
    private readonly LocalEatsContext _db;

    public CafesController(LocalEatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cafe> model = _db.Cafes.Include(cafes => cafes.Cuisine).ToList();
      ViewBag.Title = "Cafes";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.Title = "Add Cafe";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cafe cafe)
    {
      _db.Cafes.Add(cafe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cafe thisCafe = _db.Cafes.FirstOrDefault(cafe => cafe.CafeId == id);
      ViewBag.Title = "Details on " + thisCafe.CafeName;
      return View(thisCafe);
    }

    public ActionResult Edit(int id)
    {
      Cafe thisCafe = _db.Cafes.FirstOrDefault(cafe => cafe.CafeId == id);
      ViewBag.Title = "Edit " + thisCafe.CafeName;
      return View(thisCafe);
    }

    [HttpPost]
    public ActionResult Edit(Cafe cafe)
    {
      _db.Entry(cafe).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCafe = _db.Cafes.FirstOrDefault(cafe => cafe.CafeId == id);
      ViewBag.Title = "Delete " + thisCafe.CafeName;
      return View(thisCafe);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCafe = _db.Cafes.FirstOrDefault(cafe => cafe.CafeId == id);
      _db.Cafes.Remove(thisCafe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}
