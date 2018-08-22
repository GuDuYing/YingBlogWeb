using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YingBlog.EntityFramework
{
    public abstract class EntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> builder);
        public void Map(ModelBuilder builder)
        {
            Map(builder.Entity<T>());
        }
    }
}