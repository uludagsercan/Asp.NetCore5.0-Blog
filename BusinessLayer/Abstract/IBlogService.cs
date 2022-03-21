using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Update(int id);
        void Delete(int id);
        ICollection<Blog> GetAll();
        Blog GetById(int id);
        ICollection<Blog> GetWithCategory();
    }
}
