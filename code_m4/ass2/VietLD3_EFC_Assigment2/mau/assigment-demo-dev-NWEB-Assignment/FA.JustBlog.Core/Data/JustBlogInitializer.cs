using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core
{
      public static class JustBlogInitializer
      {
            public static void Seed(this ModelBuilder modelBuilder)
            {
                  modelBuilder.Entity<Category>().HasData(
                        new Category { Id = 1, Name = "Category 1", UrlSlug = "urlslug 1", Description = "Category 1 for you" },
                        new Category { Id = 2, Name = "Category 2", UrlSlug = "urlslug 2", Description = "Category 2 for you" },
                        new Category { Id = 3, Name = "Category 3", UrlSlug = "urlslug 3", Description = "Category 3 for you" },
                        new Category { Id = 4, Name = "Category 4", UrlSlug = "urlslug 4", Description = "Category 4 for you" },
                        new Category { Id = 5, Name = "Category 5", UrlSlug = "urlslug 5", Description = "Category 5 for you" }
                  );
                  modelBuilder.Entity<Post>().HasData(
                        new Post
                        {
                              Id = 1,
                              Title = "Post 1",
                              PostContent = "Post Content 1",
                              ShortDescription = "Post 1 for you",
                              UrlSlug = "urlslug 1",
                              CategoryId = 1,
                              Published = true,
                              PostedOn = new DateTime(2022, 6, 4),
                              Modified = false,
                              RateCount = 3,
                              TotalRate = 6
                        },
                        new Post
                        {
                              Id = 2,
                              Title = "Post 2",
                              PostContent = "Post Content 2",
                              ShortDescription = "Post 2 for you",
                              UrlSlug = "urlslug 2",
                              CategoryId = 4,
                              Published = false,
                              PostedOn = new DateTime(2022, 8, 4),
                              Modified = false,
                              RateCount = 3,
                              TotalRate = 3
                        },
                        new Post
                        {
                              Id = 3,
                              Title = "Post 3",
                              PostContent = "Post Content 3",
                              ShortDescription = "Post 3 for you",
                              UrlSlug = "urlslug 3",
                              CategoryId = 1,
                              Published = true,
                              PostedOn = new DateTime(2022, 8, 4),
                              Modified = false,
                              RateCount = 2,
                              TotalRate = 3
                        },
                        new Post
                        {
                              Id = 4,
                              Title = "Post 4",
                              PostContent = "Post Content 4",
                              ShortDescription = "Post 4 for you",
                              UrlSlug = "urlslug 4",
                              CategoryId = 2,
                              Published = false,
                              PostedOn = new DateTime(2022, 6, 4),
                              Modified = false,
                              RateCount = 3,
                              TotalRate = 6
                        },
                        new Post
                        {
                              Id = 5,
                              Title = "Post 5",
                              PostContent = "Post Content 5",
                              ShortDescription = "Post 5 for you",
                              UrlSlug = "urlslug 5",
                              CategoryId = 2,
                              Published = true,
                              PostedOn = new DateTime(2022, 8, 4),
                              Modified = false,
                              RateCount = 1,
                              TotalRate = 1
                        },
                        new Post
                        {
                              Id = 6,
                              Title = "Post 5",
                              PostContent = "Post Content 6",
                              ShortDescription = "Post 6 for you",
                              UrlSlug = "urlslug 6",
                              CategoryId = 1,
                              Published = true,
                              PostedOn = new DateTime(2022, 8, 4),
                              Modified = false,
                              RateCount = 2,
                              TotalRate = 1
                        }
                  );
                  modelBuilder.Entity<Tag>().HasData(
                        new Tag { Id = 1, Name = "Tag 1", UrlSlug = "urlslg 1", Description = "Tag 1 have any description", Count = 10 },
                        new Tag { Id = 2, Name = "Tag 2", UrlSlug = "urlslg 2", Description = "Tag 2 have any description", Count = 5 },
                        new Tag { Id = 3, Name = "Tag 3", UrlSlug = "urlslg 3", Description = "Tag 3 have any description", Count = 7 },
                        new Tag { Id = 4, Name = "Tag 4", UrlSlug = "urlslg 4", Description = "Tag 4 have any description", Count = 9 },
                        new Tag { Id = 5, Name = "Tag 5", UrlSlug = "urlslg 5", Description = "Tag 4 have any description", Count = 5 }
                  );
                  modelBuilder.Entity<PostTagMap>().HasData(
                        new PostTagMap { PostId = 1, TagId = 1 },
                        new PostTagMap { PostId = 4, TagId = 1 },
                        new PostTagMap { PostId = 1, TagId = 2 },
                        new PostTagMap { PostId = 1, TagId = 3 },
                        new PostTagMap { PostId = 2, TagId = 1 },
                        new PostTagMap { PostId = 2, TagId = 2 },
                        new PostTagMap { PostId = 2, TagId = 5 },
                        new PostTagMap { PostId = 2, TagId = 4 }
                  );
                  modelBuilder.Entity<Comment>().HasData(
                        new Comment
                        {
                              Id = 1,
                              Name = "Comment 1",
                              Email = "toan@gmail.com",
                              CommentHeader = "CommentHeader 1",
                              CommentText = "Comment Text 1",
                              CommentTime = DateTime.Now,
                              PostId = 1
                        },
                        new Comment
                        {
                              Id = 2,
                              Name = "Comment 2",
                              Email = "the@gmail.com",
                              CommentHeader = "CommentHeader 2",
                              CommentText = "Comment Text 2",
                              CommentTime = new DateTime(2022,6,4),
                              PostId = 1
                        },
                        new Comment
                        {
                              Id = 3,
                              Name = "Comment 3",
                              Email = "trang@gmail.com",
                              CommentHeader = "CommentHeader 3",
                              CommentText = "Comment Text 3",
                              CommentTime = DateTime.Now,
                              PostId = 2
                        },
                        new Comment
                        {
                              Id = 4,
                              Name = "Comment 4",
                              Email = "toan@gmail.com",
                              CommentHeader = "CommentHeader 4",
                              CommentText = "Comment Text 4",
                              CommentTime = new DateTime(2022,6,4),
                              PostId = 2
                        },
                        new Comment
                        {
                              Id = 5,
                              Name = "Comment 5",
                              Email = "tinh@gmail.com",
                              CommentHeader = "CommentHeader 5",
                              CommentText = "Comment Text 5",
                              CommentTime = DateTime.Now,
                              PostId = 1
                        }
                  );
            }
      }
}
