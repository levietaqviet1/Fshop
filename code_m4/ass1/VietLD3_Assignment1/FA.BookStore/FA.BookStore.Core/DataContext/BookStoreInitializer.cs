

using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Core.DataContext
{
    public static class BookStoreInitializer
    {
        public static void SeedData(this ModelBuilder builder)
        {

            //add data for Category

            builder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "abc",
                    Description = "abc",
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "vcd",
                    Description = "vcd",
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "dfr",
                    Description = "dfg",
                });

            // add data for Publisher
            builder.Entity<Publisher>().HasData(
                new Publisher
                {
                    PublisherId = 1,
                    Name = "p1",
                    Description = "p1"
                },
                new Publisher
                {
                    PublisherId = 2,
                    Name = " p2",
                    Description = "p2"
                },
                new Publisher
                {
                    PublisherId = 3,
                    Name = "p3",
                    Description = "p3"
                }
                );

            // add data for Book
            builder.Entity<Book>().HasData(
               new Book
               {
                   BookId = 1,
                   Title = "b1",
                   CategoryId = 3,
                   AuthorId = 1,
                   PublisherId = 1,
                   Summary = "b1",
                   ImgUrl = "",
                   Price = 100000,
                   Quantity = 2,
                   CreateDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   IsActive = true,

               },
               new Book
               {
                   BookId = 2,
                   Title = "b2",
                   CategoryId = 2,
                   AuthorId = 2,
                   PublisherId = 2,
                   Summary = "b2",
                   ImgUrl = "",
                   Price = 100000,
                   Quantity = 4,
                   CreateDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   IsActive = true,
               },
               new Book
               {
                   BookId = 3,
                   Title = "b3",
                   CategoryId = 1,
                   AuthorId = 2,
                   PublisherId = 3,
                   Summary = "b3",
                   ImgUrl = "",
                   Price = 100000,
                   Quantity = 4,
                   CreateDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   IsActive = false,
               });
            builder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    BookId = 1,
                    Content = "c1",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                },
                new Comment
                {
                    CommentId = 2,
                    BookId = 2,
                    Content = "c2",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                },
                new Comment
                {
                    CommentId = 3,
                    BookId = 3,
                    Content = "c3",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                },
                new Comment
                {
                    CommentId = 4,
                    BookId = 3,
                    Content = "c4",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                }
                );
        }
    }
}
