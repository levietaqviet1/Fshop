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
      public class PostTagMapConfig : IEntityTypeConfiguration<PostTagMap>
      {
            public void Configure(EntityTypeBuilder<PostTagMap> builder)
            {
                  builder.ToTable("PostTagMap");
                  builder.HasKey(x => new { x.PostId, x.TagId});
                  builder.HasOne(x => x.Tag).WithMany(x => x.PostTagMaps).HasForeignKey(x => x.TagId);
                  builder.HasOne(x => x.Post).WithMany(x => x.PostTagMaps).HasForeignKey(x => x.PostId);
            }
      }
}
