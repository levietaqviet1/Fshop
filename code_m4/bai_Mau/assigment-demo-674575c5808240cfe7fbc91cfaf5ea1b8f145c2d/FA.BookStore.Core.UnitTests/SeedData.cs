using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UnitTests
{
    public static class SeedData
    {
        public static void Seed(this BookStoreContext context)
        {
            context.AddRange(GetCategories());

            context.SaveChanges();
        }

        private static ICollection<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Category 1",
                    Description = "Description 1"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Category 2",
                    Description = "Description 2"
                }
            };
        }
    }
}
