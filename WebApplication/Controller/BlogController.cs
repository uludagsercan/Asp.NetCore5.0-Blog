using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controller
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
