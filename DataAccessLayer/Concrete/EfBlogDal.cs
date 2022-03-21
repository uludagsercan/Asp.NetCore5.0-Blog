using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfBlogDal : BlogRepository<Blog, BlogContext>, IBlogDal
    {
        public ICollection<Blog> GetAllWithCategory()
        {
            using (var context = new BlogContext())
            {
                return context.Set<Blog>().Include(x => x.Category).ToList();
            }
        }
    }
}
