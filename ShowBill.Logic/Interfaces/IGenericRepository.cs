using ShowBill.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ShowBill.Logic
{
    public interface IGenericRepository<T> where T : Event
    {
        void Create(T item);
        T FindById(int id);
        IQueryable<T> Get(
            Expression<Func<T, bool>> filter,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null);
        IQueryable<T> Get();
        void Remove(T item);
        void Update(T item);
    }
}

