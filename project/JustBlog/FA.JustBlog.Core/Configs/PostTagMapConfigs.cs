using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Configs
{
    public class PostTagMapConfigs : IEntityTypeConfiguration<PostTagMap>
    {
        public void Configure(EntityTypeBuilder<PostTagMap> builder)
        {
            builder.ToTable("PostTagMap");
            builder.HasKey(sc => new { sc.TagId, sc.PostId });
        }
    }
}
