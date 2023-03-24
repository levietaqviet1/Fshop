using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Repositories.ImplementRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreContext context;
        private ICategoryRepository categoryRepository;
        private IBookRepository bookRepository;
        private IPublisherRepository publisherRepository;

        public UnitOfWork(BookStoreContext context = null)
        {
            this.context = context ?? new BookStoreContext();
        }

        public IBookRepository BookRepository => bookRepository ?? new BookRepository(context);

        public ICategoryRepository CategoryRepository => categoryRepository ?? new CategoryRepository(context);

        public IPublisherRepository PublisherRepository => publisherRepository ?? new PublisherRepository(context);

        public void SaveChange()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                    Console.WriteLine("Dispose");

                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            Console.WriteLine("Dispose");
            GC.SuppressFinalize(this);
        }

    }
}
