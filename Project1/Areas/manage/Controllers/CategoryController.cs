using Microsoft.AspNetCore.Mvc;
using System;

namespace Project1.Areas.manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
