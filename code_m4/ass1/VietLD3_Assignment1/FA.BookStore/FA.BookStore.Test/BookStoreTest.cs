using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Repositories.ImplementRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;
using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Test
{
    public class BookStoreTest
    {
        protected ICategoryRepository categoryRepository;
        protected IBookRepository bookRepository;
        protected IPublisherRepository publisherRepository;
        protected ICommentRepository commentRepository;
        protected BookStoreContext context;

        public BookStoreTest()
        {
            DbContextOptions<BookStoreContext> dbContextOptions = new DbContextOptionsBuilder<BookStoreContext>
             ().UseInMemoryDatabase(databaseName: "BookStoreDB").Options;

            context = new BookStoreContext(dbContextOptions);
            context.SeeData();

            categoryRepository = new CategoryRepository(context);
            bookRepository = new BookRepository(context);
            publisherRepository = new PublisherRepository(context);
            commentRepository = new CommentRepository(context);

        }
    }
}