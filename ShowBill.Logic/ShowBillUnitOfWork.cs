using Microsoft.EntityFrameworkCore;
using ShowBill.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Logic
{
    public class ShowBillUnitOfWork : IShowBillUnitOfWork, IDisposable
    {
        private readonly ShowBillDbContext _context;
        private bool disposed = false;

        public ShowBillUnitOfWork(ShowBillDbContext dbContext)
        {
            _context = dbContext;
            ConcertRepository = new Repository<Concert>(_context);
            ExhibitionRepository = new Repository<Exhibition>(_context);
            MovieRepository = new Repository<Movie>(_context);
            PerformanceRepository = new Repository<Performance>(_context);
            SportRepository = new Repository<Sport>(_context);
        }

        public IGenericRepository<Concert> ConcertRepository { get; set; }
        public IGenericRepository<Exhibition> ExhibitionRepository { get; set; }
        public IGenericRepository<Movie> MovieRepository { get; set; }
        public IGenericRepository<Performance> PerformanceRepository { get; set; }
        public IGenericRepository<Sport> SportRepository { get; set; }

        public Event FindGlobally(Guid id)
        {
            return _context.GetType().GetProperties()
                .Where(p => p.PropertyType.IsGenericType)
                .Where(p => p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                .Where(p => p.PropertyType.GetGenericArguments().First().IsSubclassOf(typeof(Event)))
                .SelectMany(p => (IEnumerable<Event>)p.GetValue(_context, null))
                .Where(obj => obj.Id == id)
                .First();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

