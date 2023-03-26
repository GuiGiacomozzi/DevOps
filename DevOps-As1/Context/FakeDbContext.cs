using DevOps_As1.Models;
using Microsoft.EntityFrameworkCore;

namespace DevOps_As1.Context
{
    public class FakeDbContext : DbContext
    {
        public FakeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().ToTable("Produto");

            base.OnModelCreating(builder);
        }
    }
}
