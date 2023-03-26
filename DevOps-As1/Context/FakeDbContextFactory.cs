using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DevOps_As1.Context
{
    public class FakeDbContextFactory : IDesignTimeDbContextFactory<FakeDbContext>
    {
        public FakeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FakeDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-4JH7I5I\\SQLEXPRESS01;Database=AtividadeSomativa;Trusted_Connection=True;TrustServerCertificate=True;");

            return new FakeDbContext(optionsBuilder.Options);
        }
    }
}