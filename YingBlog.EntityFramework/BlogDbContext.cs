using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YingBlog.Core.Entities;

namespace YingBlog.EntityFramework
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {

        }

        //创建日志工厂
        private static ILoggerFactory Mlogger => new LoggerFactory()
            .AddConsole((categoryName, logLevel) =>
                (logLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name));


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(Mlogger);
        }

        public DbSet<BlogUserEntity> BlogUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //查找所有FluentAPI配置
            modelBuilder.AddEntityConfigurationsFromAssembly(GetType().Assembly);


        }
    }
}