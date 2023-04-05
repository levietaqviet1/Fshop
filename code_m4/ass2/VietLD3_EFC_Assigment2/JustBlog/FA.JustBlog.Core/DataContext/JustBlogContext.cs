using FA.JustBlog.Core.Configs;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.DataContext
{
    public class JustBlogContext : IdentityDbContext<UsingIdentityUser>
    {
        /// <summary>
        /// constructor ko tham số
        /// </summary>
        public JustBlogContext()
        {
        }

        /// <summary>
        /// constructor có tham số. Nhận vào một tham số là DbContextOptions, đại diện cho các tùy chọn cấu hình để thiết lập kết nối tới cơ sở dữ liệu. 
        /// </summary>
        /// <param name="options"></param>
        public JustBlogContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// định nghĩa Category trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// định nghĩa Post trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        /// <summary>
        ///  định nghĩa Tag trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<Tag> Tags { get; set; }
        /// <summary>
        /// định nghĩa PostTagMap trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<PostTagMap> PostTagMaps { get; set; }
        /// <summary>
        /// định nghĩa Comment trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //        optionsBuilder.UseSqlServer(config.GetConnectionString("MyCnn"));
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfigs).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfigs).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagConfigs).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagMapConfigs).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommentConfigs).Assembly);
            modelBuilder.SeedData();
        }
    }
}
