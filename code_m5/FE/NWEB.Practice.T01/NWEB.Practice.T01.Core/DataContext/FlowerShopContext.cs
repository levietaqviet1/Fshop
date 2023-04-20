using Microsoft.EntityFrameworkCore;
using NWEB.Practice.T01.Core.Configs;
using NWEB.Practice.T01.Core.Model;

namespace NWEB.Practice.T01.Core.DataContext
{
    public class FlowerShopContext : DbContext
    {

        /// <summary>
        /// constructor ko tham số
        /// </summary>
        public FlowerShopContext()
        {
        }

        /// <summary>
        /// constructor có tham số. Nhận vào một tham số là DbContextOptions, đại diện cho các tùy chọn cấu hình để thiết lập kết nối tới cơ sở dữ liệu. 
        /// </summary>
        /// <param name="options"></param>
        public FlowerShopContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// định nghĩa Category trong cơ sở dữ liệu.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        public DbSet<Flower> Flowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FlowerStoreDB1;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfigs).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FlowerConfigs).Assembly);
            modelBuilder.SeedData();
        }
    }
}
