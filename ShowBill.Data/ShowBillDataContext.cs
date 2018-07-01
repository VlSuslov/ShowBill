using Microsoft.EntityFrameworkCore;
using ShowBill.Models;

namespace ShowBill.Data
{
    public class ShowBillDbContext : DbContext
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
        public DbSet<TimePeriod> Time { get; set; }

        public ShowBillDbContext(DbContextOptions<ShowBillDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
