using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NWEB.Practice.T01.Core.Model;

namespace NWEB.Practice.T01.Core.Configs
{
    public class FlowerConfigs : IEntityTypeConfiguration<Flower>
    {
        /// <summary>
        /// connfigs for flower
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Flower> builder)
        {
            builder.ToTable("Flower");
            builder.Property(f => f.Name).IsRequired().HasMaxLength(255);
            builder.Property(f => f.Price).IsRequired();
            builder.Property(f => f.StoreDate).IsRequired();
            builder.Property(f => f.StoreInventory).IsRequired();

        }
    }
}
