using Microsoft.EntityFrameworkCore;
using ShowBill.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ShowBill.Logic
{
    public class Repository<T> : IGenericRepository<T> where T : Event
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IQueryable<T> Get()
        {
            return _entities.Select(p => p);
        }

        public IQueryable<T> Get(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = null,
        int? skip = null,
        int? take = null)
        {
            includeProperties = includeProperties ?? string.Empty;
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query;
        }

        public T FindById(int id)
        {
            return _entities.Find(id);
        }

        public void Create(T item)
        {
            _entities.Add(item);
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Remove(T item)
        {
            _entities.Remove(item);
        }
    }
}

