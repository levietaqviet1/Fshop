using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core
{
      public class TagConfig: IEntityTypeConfiguration<Tag>
      {
            public void Configure(EntityTypeBuilder<Tag> builder)
            {
                  builder.ToTable("Tag");
                  builder.HasKey(x => x.Id);
                  builder.Property(x => x.Id).ValueGeneratedOnAdd();
                  builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
                  builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);
                  builder.Property(x => x.UrlSlug).IsRequired().HasMaxLength(255);
                  builder.Property(x => x.Count).HasDefaultValue(1);
            }
      }
}
