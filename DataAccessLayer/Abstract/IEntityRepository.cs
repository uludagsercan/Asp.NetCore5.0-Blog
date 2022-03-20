using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEntityRepository <T> 
     
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        ICollection<T> GetAll();
        T Get(Expression<Func<T, bool>> predicate);
        ICollection<T> GetAll(Expression<Func<T, bool>> predicate=null);
    }
}
