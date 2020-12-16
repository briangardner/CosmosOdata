using CosmosOdata.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CosmosOdata
{
    public class TestEntityConfiguration : IEntityTypeConfiguration<TestEntity>
    {
        public void Configure(EntityTypeBuilder<TestEntity> builder)
        {
            builder.ToContainer("TestEntities").HasNoDiscriminator();
            builder.HasPartitionKey(x => x.PartitionKey);
            builder.Property(x => x.Id).ToJsonProperty("id");
            builder.OwnsMany(x => x.TestSubEntities, tse =>
            {
            });



        }
    }
}
