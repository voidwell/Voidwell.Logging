using Microsoft.AspNetCore.Mvc;

namespace DemoApp
{
    [Route("/")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
