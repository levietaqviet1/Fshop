using Microsoft.EntityFrameworkCore;
using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.BookStore.Core.Configs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(x => x.BookId);

            builder.HasOne(x => x.Category).WithMany(x => x.Books).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Publisher).WithMany(x => x.Books).HasForeignKey(x => x.PublisherId);

        }
    }
}
