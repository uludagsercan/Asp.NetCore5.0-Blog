using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("/api/[Controller]")]
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager;

        public CategoryController()
        {
            _categoryManager = new CategoryManager(new EfCategoryDal());
        }

        [HttpGet("getall")]
        public ICollection<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }
    }
}
