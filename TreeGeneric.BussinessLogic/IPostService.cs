using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface IPostService
    {
        //validasyonlar ve iş akısı için
        //interface de ise data işlemleri
        void Insert(Post post);
        void update(Post post);
        void Delete(int id);
        Planting Find(int id);
        Planting Find(Expression<Func<Post, bool>> where);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where);

    }
}
