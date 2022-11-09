using System.Collections.Generic;

namespace Domain.Infraestructure.Repository
{
    public interface IRepostiroy<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
