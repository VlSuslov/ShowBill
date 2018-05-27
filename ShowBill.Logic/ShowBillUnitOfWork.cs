using ShowBill.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Logic
{
    public class ShowBillUnitOfWork : IShowBillUnitOfWork, IDisposable
    {
        private readonly ShowBillDbContext _context;
        private readonly string _concertsIncludes = "Place,Photos,Dates,Duration,Seanses,Artists";
        private readonly string _moviesIncludes = "Place,Photos,Dates,Duration,Seanses,Actors,Director,Composers,Screenwriters,Producers";
        private readonly string _performancesIncludes = "Place,Photos,Dates,Duration,Seanses,Actors,Director,Authors";
        private readonly string _sportIncludes = "Place,Photos,Dates,Duration,Seanses";
        private readonly string _exhibitionsIncludes = "Place,Photos,Dates,Duration,Seanses,Artists";

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

        public IQueryable<Event> GetAll()
        {
            //temporary solution caused by ef bug
            IEnumerable<Event> events = new List<Event>();
            events = events.Concat(ConcertRepository.Get(null, includeProperties: _concertsIncludes).ToList())
            .Concat(MovieRepository.Get(null, includeProperties: _moviesIncludes).ToList())
            .Concat(SportRepository.Get(null, includeProperties: _sportIncludes).ToList())
            .Concat(PerformanceRepository.Get(null, includeProperties: _performancesIncludes).ToList())
            .Concat(ExhibitionRepository.Get(null, includeProperties: _exhibitionsIncludes).ToList());
            return events.AsQueryable();
        }

        public Event FindGlobally(Guid id)
        {
            return this.GetAll()
                .Where(obj => obj.Id == id)
                .First();
        }

        public IQueryable<Event> FilterTypes(EventType? type)
        {
            switch (type)
            {
                case EventType.Concert: return ConcertRepository.Get(null, includeProperties: _concertsIncludes);
                case EventType.Exhibition: return ExhibitionRepository.Get(null, includeProperties: _exhibitionsIncludes);
                case EventType.Movie: return MovieRepository.Get(null, includeProperties: _moviesIncludes);
                case EventType.Performance: return PerformanceRepository.Get(null, includeProperties: _performancesIncludes);
                case EventType.Sport: return PerformanceRepository.Get(null, includeProperties: _exhibitionsIncludes);
                default: return GetAll();
            }
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

