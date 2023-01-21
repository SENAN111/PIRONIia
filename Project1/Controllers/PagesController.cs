using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
