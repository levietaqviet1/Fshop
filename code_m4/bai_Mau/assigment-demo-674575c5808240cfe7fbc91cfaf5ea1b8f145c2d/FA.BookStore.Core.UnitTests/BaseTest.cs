using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Repository.ImplementRepo;
using FA.BookStore.Core.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UnitTests
{
    public class BaseTest
    {
        protected ICategoryRepository categoryRepository;
        protected IBookRepository bookRepository;
        protected BookStoreContext context;

        public BaseTest()
        {
            DbContextOptions<BookStoreContext> dbContextOptions= new DbContextOptionsBuilder<BookStoreContext>().UseInMemoryDatabase(databaseName: "BookStoreDB2").Options;

            context = new BookStoreContext(dbContextOptions);
            context.Seed();

            categoryRepository = new CategoryRepository(context);
            bookRepository = new BookRepository(context);
        }
    }
}
