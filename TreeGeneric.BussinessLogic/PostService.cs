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
    public class PostService : IPostService
    {
        private readonly IRepository<Post> repository;
        public PostService(IRepository<Post> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var postToDelete = repository.Find(id);
            if (postToDelete != null)
            {
                repository.Delete(postToDelete);
            }
        }      

        public Post Find(Expression<Func<Post, bool>> where)
        {
            return repository.Find(where);

        }

        public IEnumerable<Post> GetAll()
        {
            return repository.GetAll(r => true);//tum kayıtlar gelir
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(Post post)
        {
            repository.Insert(post);

        }

        public void update(Post post)
        {
            repository.Update(post);
        }       

        public Post Find(int id)
        {
            return repository.Find(id);

        }

        Planting IPostService.Find(int id)
        {
            throw new NotImplementedException();
        }

        Planting IPostService.Find(Expression<Func<Post, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
