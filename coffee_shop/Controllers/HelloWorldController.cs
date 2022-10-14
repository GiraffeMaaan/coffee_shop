using Microsoft.AspNetCore.Mvc;

namespace coffeeshop.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string welcome()
        {
            return "Welcomeページです";
        }
    }
}
