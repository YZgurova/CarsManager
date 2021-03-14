using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CarsManagerDb : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-FK4S744E\\SQLEXPRESS;Database=CarsManagerDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
