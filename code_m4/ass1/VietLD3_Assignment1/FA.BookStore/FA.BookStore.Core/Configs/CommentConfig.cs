using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.BookStore.Core.Configs
{
    public class CommentConfig
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(c => c.CommentId);

            builder.Property(c => c.Content).IsRequired().HasMaxLength(200);
        }
    }
}
