using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;
using TreeGenericData;

namespace TreeGeneric.BussinessLogic
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> user;
        public UserService(IRepository<User> repository)
        {
            this.user = repository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        public User Find(Expression<Func<User, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Insert(User user)
        {
            throw new NotImplementedException();
        }

        public void update(User user)
        {
            throw new NotImplementedException();
        }

        //public void Delete(int id)
        //{
        //    var userToDelete = repository.Find(id);
        //    if (userToDelete != null)
        //    {
        //        repository.Delete(userToDelete);
        //    }
        //}

        //public User Find(int id)
        //{
        //    return repository.Find(id);

        //}

        //public User Find(Expression<Func<User, bool>> where)
        //{
        //    return repository.Find(where);

        //}

        //public IEnumerable<User> GetAll()
        //{
        //    return repository.GetAll(r => true);//tum kayıtlar gelir
        //}

        //public IEnumerable<User> GetAll(Expression<Func<User, bool>> where)
        //{
        //    return repository.GetAll(where);
        //}

        //public void Insert(User user)
        //{
        //    repository.Insert(user);

        //}

        //public void update(User user)
        //{
        //    repository.Update(user);
        //}
    }
}
