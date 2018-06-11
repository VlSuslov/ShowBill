using ShowBill.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Logic
{
    public class EventMetaRepository : IEventMetaRepository
    {
        private readonly ShowBillDbContext _context;
        private readonly string _concertsIncludes = "Place,Photos,Dates,Duration,Seanses,Artists";
        private readonly string _moviesIncludes = "Place,Photos,Dates,Duration,Seanses,Actors,Director,Composers,Screenwriters,Producers";
        private readonly string _performancesIncludes = "Place,Photos,Dates,Duration,Seanses,Actors,Director,Authors";
        private readonly string _sportIncludes = "Place,Photos,Dates,Duration,Seanses";
        private readonly string _exhibitionsIncludes = "Place,Photos,Dates,Duration,Seanses,Artists";


        public EventMetaRepository(ShowBillDbContext dbContext)
        {
            _context = dbContext;
            ConcertRepository = new Repository<Concert>(_context);
            ExhibitionRepository = new Repository<Exhibition>(_context);
            MovieRepository = new Repository<Movie>(_context);
            PerformanceRepository = new Repository<Performance>(_context);
            SportRepository = new Repository<Sport>(_context);
        }

        public IGenericRepository<Concert> ConcertRepository { get; }
        public IGenericRepository<Exhibition> ExhibitionRepository { get; }
        public IGenericRepository<Movie> MovieRepository { get; }
        public IGenericRepository<Performance> PerformanceRepository { get; }
        public IGenericRepository<Sport> SportRepository { get; }

        public IQueryable<Event> GetAll(bool includeAll = true)
        {
            //temporary solution caused by ef bug
            IEnumerable<Event> events = new List<Event>();
            events = events.Concat(ConcertRepository
                .Get(null, includeProperties: includeAll ? _concertsIncludes : string.Empty)
                .ToList())
            .Concat(MovieRepository
                .Get(null, includeProperties: includeAll ? _moviesIncludes : string.Empty)
                .ToList())
            .Concat(SportRepository
                .Get(null, includeProperties: includeAll ? _sportIncludes : string.Empty)
                .ToList())
            .Concat(PerformanceRepository
                .Get(null, includeProperties: includeAll ? _performancesIncludes : string.Empty)
                .ToList())
            .Concat(ExhibitionRepository
                .Get(null, includeProperties: includeAll ? _exhibitionsIncludes : string.Empty)
                .ToList());
            return events.AsQueryable();
        }

        public Event FindById(Guid id, bool includeAll)
        {
            return this.GetAll(includeAll)
                .Where(obj => obj.Id == id)
                .First();
        }

        public IQueryable<Event> Get(EventType? type, bool includeAll = true)
        {
            switch (type)
            {
                case EventType.Concert:
                    {
                        return ConcertRepository.Get(null, includeProperties: includeAll ? _concertsIncludes : string.Empty);
                    }
                case EventType.Exhibition:
                    {
                        return ExhibitionRepository.Get(null, includeProperties: includeAll ? _exhibitionsIncludes : string.Empty);
                    }
                case EventType.Movie:
                    {
                        return MovieRepository.Get(null, includeProperties: includeAll ? _moviesIncludes : string.Empty);
                    }
                case EventType.Performance:
                    {
                        return PerformanceRepository.Get(null, includeProperties: includeAll ? _performancesIncludes : string.Empty);
                    }
                case EventType.Sport:
                    {
                        return SportRepository.Get(null, includeProperties: includeAll ? _sportIncludes : string.Empty);
                    }
                default: return GetAll(includeAll);
            }
        }
    }
}

