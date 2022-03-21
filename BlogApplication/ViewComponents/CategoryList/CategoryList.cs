using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.CategoryList
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var result = cm.GetAll();
            return View(result);
        }
    }
}
