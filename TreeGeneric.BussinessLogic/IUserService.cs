using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface IUserService
    {
        //validasyonlar ve iş akısı için
        //interface de ise data işlemleri
        void Insert(User user);
        void update(User user);
        void Delete(int id);
        User Find(int id);
        User Find(Expression<Func<User, bool>> where);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetAll(Expression<Func<User, bool>> where);

    }
}
