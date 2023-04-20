using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NWEB.Practice.T01.Core.Model;

namespace NWEB.Practice.T01.Core.Configs
{
    public class CategoryConfigs : IEntityTypeConfiguration<Category>
    {
        /// <summary>
        /// configs for category
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Order).IsRequired().HasDefaultValue(1);
        }
    }
}
