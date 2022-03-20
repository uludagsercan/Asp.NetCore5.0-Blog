using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public void Add(Category category);
        public void Update(int id);
        public void Delete(int id);
        public ICollection<Category> GetAll();
        public Category GetById(int id);

    }
}
