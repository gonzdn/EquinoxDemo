using Microsoft.EntityFrameworkCore;

namespace Equinox.Infra.Data.Context
{
    public sealed class EquinoxContext : DbContext
    {
        public EquinoxContext(DbContextOptions<EquinoxContext> options) : base(options)
        {

        }

        //public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
