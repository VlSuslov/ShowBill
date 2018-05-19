﻿using ShowBill.Data;
using System;

namespace ShowBill.Logic
{
    public interface IShowBillUnitOfWork
    {
        IGenericRepository<Concert> ConcertRepository { get; set; }
        IGenericRepository<Exhibition> ExhibitionRepository { get; set; }
        IGenericRepository<Movie> MovieRepository { get; set; }
        IGenericRepository<Performance> PerformanceRepository { get; set; }
        IGenericRepository<Sport> SportRepository { get; set; }
        Event FindGlobally(Guid id);
        void Save();
    }
}
