using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(int id)
        {
            var result = _blogDal.Get(x => x.BlogId == id);
            _blogDal.Delete(result);
        }

        public ICollection<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(x => x.BlogId == id);
        }

        public ICollection<Blog> GetWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }

        public void Update(int id)
        {
            var result = _blogDal.Get(x => x.BlogId == id);
            _blogDal.Update(result);
        }
    }
}
