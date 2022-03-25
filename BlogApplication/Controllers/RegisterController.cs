using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class RegisterController : Controller
    {
        IWriterService _service;

        public RegisterController(IWriterService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index(bool success)
        {
            if (success)
            {
                ViewBag.Success = success;
            }
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserForDto userForDto)
        {
            var result = _service.Register(userForDto);
            return RedirectToAction("Index",new { success=result.Success });
        }
    }
}
