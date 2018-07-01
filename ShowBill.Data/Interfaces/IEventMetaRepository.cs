using ShowBill.Models;
using System;
using System.Linq;

namespace ShowBill.Data
{
    public interface IEventMetaRepository
    {
        IGenericRepository<Concert> ConcertRepository { get; }
        IGenericRepository<Exhibition> ExhibitionRepository { get; }
        IGenericRepository<Movie> MovieRepository { get; }
        IGenericRepository<Performance> PerformanceRepository { get; }
        IGenericRepository<Sport> SportRepository { get; }
        Event FindById(Guid id, bool includeAll = true);
        IQueryable<Event> Get(EventType? type, bool includeAll = true);
        IQueryable<Event> GetAll(bool includeAll = true);
    }
}

