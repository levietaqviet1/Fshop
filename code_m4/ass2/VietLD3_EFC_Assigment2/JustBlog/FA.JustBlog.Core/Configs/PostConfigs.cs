using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Configs
{
    public class PostConfigs : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PostContent).IsRequired().HasMaxLength(500);
            builder.Property(x => x.UrlSlug).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Published).HasDefaultValue(false);
            builder.Property(x => x.ViewCount).HasDefaultValue(0);
            builder.Property(x => x.RateCount).HasDefaultValue(0);
            builder.Property(x => x.TotalRate).HasDefaultValue(0);
            builder.Property(x => x.Rate).HasDefaultValue(0);

        }
    }
}
