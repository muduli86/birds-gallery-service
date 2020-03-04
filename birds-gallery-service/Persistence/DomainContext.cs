using birds_gallery_service.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace birds_gallery_service.Persistence
{
    public class DomainContext: DbContext
    {
        public DomainContext(DbContextOptions<DomainContext> options) : base(options) {}
        public DbSet<Birds> Birds { get; set; }
    }

    //public class DomainContextFactory : IDesignTimeDbContextFactory<DomainContext>
    //{
    //    public DomainContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<DomainContext>();
    //        optionsBuilder.UseNpgsql(@"Server=localhost; Port= 5432; Database=Photography; User Id=postgres; Password=postgres");
    //        return new DomainContext(optionsBuilder.Options);
    //    }
    //}
}
