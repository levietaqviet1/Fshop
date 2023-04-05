//using FA.JustBlog.Areas.Identity.Data;
//using FA.JustBlog.Core.Configs;
//using FA.JustBlog.Core.DataContext;
//using FA.JustBlog.Core.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace FA.JustBlog.Data;

//public class FAJustBlogContext : IdentityDbContext<UsingIdentityUser>
//{
//    public FAJustBlogContext(DbContextOptions<FAJustBlogContext> options)
//        : base(options)
//    {
//    }


//    /// <summary>
//    /// định nghĩa Category trong cơ sở dữ liệu.
//    /// </summary>
//    public DbSet<Category> Categories { get; set; }
//    /// <summary>
//    /// định nghĩa Post trong cơ sở dữ liệu.
//    /// </summary>
//    public DbSet<Post> Posts { get; set; }
//    /// <summary>
//    ///  định nghĩa Tag trong cơ sở dữ liệu.
//    /// </summary>
//    public DbSet<Tag> Tags { get; set; }
//    /// <summary>
//    /// định nghĩa PostTagMap trong cơ sở dữ liệu.
//    /// </summary>
//    public DbSet<PostTagMap> PostTagMaps { get; set; }
//    /// <summary>
//    /// định nghĩa Comment trong cơ sở dữ liệu.
//    /// </summary>
//    public DbSet<Comment> Comments { get; set; }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        base.OnModelCreating(modelBuilder);

//        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfigs).Assembly);
//        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfigs).Assembly);
//        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagConfigs).Assembly);
//        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagMapConfigs).Assembly);
//        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommentConfigs).Assembly);
//        modelBuilder.SeedData();
//    }
//}
