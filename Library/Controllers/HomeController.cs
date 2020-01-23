using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult Books()
      {
          return View();
      }

      [HttpPost]
      public ActionResult Books(string Description)
      {
          ViewBag.SearchKey = Description;

          return View();
      }

      // public ActionResult Authors()
      // {
      //     return View();
      // }

      // [HttpPost]
      // public ActionResult Authors(string Name)
      // {
      //     ViewBag.SearchKey = Name;

      //     return View();
      // }
    }
}
