using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.CommentListByBlog
{
    public class CommentListByBlog:ViewComponent
    {
        private CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var result = cm.GetAllByBlogId(id);
            return View(result);
        }
    }
}
