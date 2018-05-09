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

        public ShowBillDataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShowBill;Trusted_Connection=True;");
        }
    }
}
