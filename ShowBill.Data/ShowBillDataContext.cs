using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowBill.Data
{
   public class ShowBillDataContext : DbContext
    {
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Photo> Photos { get; set; }


        public ShowBillDataContext(DbContextOptions<ShowBillDataContext> options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
