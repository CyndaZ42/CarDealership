using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/new")]
      public ActionResult CreateForm()
      {
        return View();
      }
    }
}