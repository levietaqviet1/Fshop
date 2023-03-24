using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;

namespace FA.BookStore.Test
{
    public static class SeedDataTest
    {
        public static void SeeData(this BookStoreContext context)
        {
            context.Categories.AddRange(GetCategories());
            context.Books.AddRange(GetBooks());
            context.Publishers.AddRange(GetPublishers());
            context.Comments.AddRange(GetComments());
            context.SaveChanges();
        }
        private static ICollection<Category> GetCategories()
        {
            return new List<Category>()
            {
               new Category
               {
                   CategoryId= 1,
                   CategoryName = "Fantasy",
                   Description = "The fantasy genre involves world-building and characters who are supernatural, mythological, magical, or a combination of these.",
               },
               new Category
               {
                   CategoryId= 2,
                   CategoryName = "Romance",
                   Description = "Any novel where the main storyline centers on a romantic relationship falls into this category, which has several subgenres.",
               },
               new Category
               {
                   CategoryId= 3,
                   CategoryName = "Horror",
                   Description = "e goal of this genre is to scare your readers and keep them that way until the hero vanquishes the threat.",
               }
            };
        }

        private static ICollection<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book
               {
                   BookId = 1,
                   Title = "The Shining by Stephen King",
                   CategoryId = 3,
                   AuthorId = 1,
                   PublisherId = 1,
                   Summary = "The Shining is a 1977 horror novel by American author Stephen King. It is King's third published novel and first hardback bestseller; its success firmly established King as a preeminent author in the horror genre. The setting and characters are influenced by King's personal experiences, including both his visit to The Stanley Hotel in 1974 and his struggle with alcoholism. The novel was adapted into a 1980 film and a 1997 miniseries.",
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
                   Title = "The Overdue Life of Amy Byler",
                   CategoryId = 2,
                   AuthorId = 2,
                   PublisherId = 2,
                   Summary = "Overworked and underappreciated, single mom Amy Byler needs a break. So when the guilt-ridden husband who abandoned her shows up and offers to take care of their kids for the summer, she accepts his offer and escapes rural Pennsylvania for New York City.",
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
                   Title = "Game of Thrones",
                   CategoryId = 1,
                   AuthorId = 2,
                   PublisherId = 3,
                   Summary = "Game of Thrones is an American fantasy drama television series created by David Benioff and D. B. Weiss for HBO. It is an adaptation of A Song of Ice and Fire, a series of fantasy novels by George R. R. Martin, the first of which is A Game of Thrones.",
                   ImgUrl = "",
                   Price = 100000,
                   Quantity = 4,
                   CreateDate = DateTime.Now,
                   ModifiedDate = DateTime.Now,
                   IsActive = false,
               }
            };
        }

        private static ICollection<Publisher> GetPublishers()
        {
            return new List<Publisher>()
            {
                new Publisher
                {
                    PublisherId = 1,
                    Name = "Doubleday",
                    Description = "Doubleday is an American publishing company. It was founded as the Doubleday & McClure Company in 1897 and was the largest in the United States by 1947."
                },
                new Publisher
                {
                    PublisherId = 2,
                    Name = " Kindle Edition",
                    Description = "Kindle is the brand name of a range of e-readers and tablets (called Kindle Fire) produced by Amazon. Typically books bought as a Kindle Edition will be downloaded directed to a Kindle device attached to your Amazon account."
                },
                new Publisher
                {
                    PublisherId = 3,
                    Name = "Mark Huffam",
                    Description = "CBE, is a Northern Irish film and television producer. He was a producer on The Martian, Johnny English, and the television series Game of Thrones."
                }
            };
        }

        private static ICollection<Comment> GetComments()
        {
            return new List<Comment>()
            {
                new Comment
                {
                    CommentId= 1,
                    BookId= 1,
                    Content = "This book is very engaging, and the plot is thrilling",
                    CreatedDate= DateTime.Now,
                    IsActice= true,
                },
                new Comment
                {
                    CommentId = 2,
                    BookId = 2,
                    Content = "This book is very engaging, and the plot is thrilling",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                },
                new Comment
                {
                    CommentId = 3,
                    BookId = 3,
                    Content = "This book is very engaging, and the plot is thrilling",
                    CreatedDate = DateTime.Now,
                    IsActice = true,
                }
            };
        }

    }
}
