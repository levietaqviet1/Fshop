using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.DataContext
{
    public static class BookStoreInitializer
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Trưa 27/3, đường ống nước bị vỡ trên đường Phạm Văn Đồng đã cơ bản được khắc phục. Việc cung cấp nước cho người dân sử dụng bình thường trở lại sau 2 ngày bị gián đoạn.",
                    Description = "Description 1",
                    UrlSlug = "trua-27-3-dung-ng-nuc-b-v-tren-dung-phm-van-dng-da-co-bn-duc-khc-phc"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Category 2",
                    Description = "Description 2",
                    UrlSlug = ""
                }
            );

            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Book 1",
                    CategoryId = 1
                }
            );
        }
    }
}
