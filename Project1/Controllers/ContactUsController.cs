using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
