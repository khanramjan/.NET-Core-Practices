using Microsoft.AspNetCore.Mvc;

namespace ViewsExample.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
