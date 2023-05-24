using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> FindAll();

        public void Delete(T entity);

        public T GetById(int id);   

        public void Update(T entity);
        public void Add(T entity); 
    }
}
