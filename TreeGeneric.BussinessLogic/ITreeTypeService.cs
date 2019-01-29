using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface ITreeTypeService
    {
        //validasyonlar ve iş akısı için
        //interface de ise data işlemleri
        void Insert(TreeType treetype);
        void update(TreeType treetype);
        void Delete(int id);
        TreeType Find(int id);
        TreeType Find(Expression<Func<TreeType, bool>> where);
        IEnumerable<TreeType> GetAll();
        IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> where);

    }
}
