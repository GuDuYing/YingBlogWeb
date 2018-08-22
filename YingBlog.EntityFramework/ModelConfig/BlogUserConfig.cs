using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YingBlog.Core.Entities;

namespace YingBlog.EntityFramework.ModelConfig
{
    class BlogUserConfig:EntityTypeConfiguration<BlogUserEntity>
    {
        public override void Map(EntityTypeBuilder<BlogUserEntity> builder)
        {
            builder.ToTable("T_BlogUser");
        }
    }
}