using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        T TGetById(int id);
        List<T> TGetAll();
        List<T> TGetByFilter(Expression<Func<T, bool>> filter);
    }
}
