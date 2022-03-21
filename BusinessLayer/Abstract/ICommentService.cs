using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        ICollection<Comment> GetAllByBlogId(int id);
        void Add(Comment comment);
    }
}
