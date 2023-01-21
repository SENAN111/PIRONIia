using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
