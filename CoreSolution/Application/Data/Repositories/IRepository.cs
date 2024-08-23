using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
