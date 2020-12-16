using CosmosOdata.Models;
using Microsoft.EntityFrameworkCore;

namespace CosmosOdata
{
    public class CosmosDbContext : DbContext
    {
        public CosmosDbContext(DbContextOptions<CosmosDbContext> options): base(options)
        {
            
        }

        public DbSet<TestEntity> TestEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestEntityConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
