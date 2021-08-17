using Microsoft.AspNetCore.Mvc;

namespace PierreShop.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}