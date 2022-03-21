using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var result = bm.GetWithCategory();
            return View(result);
        }
        public IActionResult Detail(int id)
        {
            var result = bm.GetById(id);
            ViewBag.i=id;
            return View(result);
        }
    }
}
