using Microsoft.AspNetCore.Mvc;

namespace MecanicNew.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
