using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //ContentResult result = new ContentResult();
        //    //  result.Content= "Hello from index action";
        //    return Content("Hello from index ");
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
