using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
