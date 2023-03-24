using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.BookStore.Core.Configs
{
    public class PublisherConfig
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publisher");
            builder.HasKey(p => p.PublisherId);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
        }
    }
}
