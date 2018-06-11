using System;

namespace ShowBill.Logic
{
    public class ShowBillUnitOfWork : IShowBillUnitOfWork
    {
        private readonly ShowBillDbContext _context;
        private bool disposed = false;

        public IEventMetaRepository MetaRepository { get; }

        public ShowBillUnitOfWork(ShowBillDbContext dbContext)
        {
            this._context = dbContext;
            MetaRepository = new EventMetaRepository(_context);
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
