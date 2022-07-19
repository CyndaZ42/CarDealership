using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {

      [HttpPost("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}