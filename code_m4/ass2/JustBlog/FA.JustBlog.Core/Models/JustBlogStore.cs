using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Models
{
    public static class JustBlogStore
    {
        public static void SeedData(this ModelBuilder builder)
        {
            // add data 

            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "PRO",
                    UrlSlug = "abc.com",
                    Description = "abc"
                }
                );
        }
    }
}
