using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Car> allCars = Car.GetAllCars();
        return View(allCars);
      }

      [HttpGet("/new")]
      public ActionResult MakeCar()
      {
        return View();
      }

      [HttpPost("/showCars")]
      public ActionResult DisplayCars(string makeModel, int price, int miles)
      {
        Car myCar = new Car(makeModel, price, miles);
        return RedirectToAction("Index");
      }
    }
}