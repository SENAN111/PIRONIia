using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
