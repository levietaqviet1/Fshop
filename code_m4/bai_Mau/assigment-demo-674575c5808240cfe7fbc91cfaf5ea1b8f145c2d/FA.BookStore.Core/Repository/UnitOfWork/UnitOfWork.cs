using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Repository.ImplementRepo;
using FA.BookStore.Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreContext context;
        private ICategoryRepository categoryRepository;
        private IBookRepository bookRepository;

        public UnitOfWork(BookStoreContext context =null)
        {
            this.context = context ?? new BookStoreContext();
        }

        public IBookRepository BookRepository => bookRepository ?? new BookRepository(context);

        public ICategoryRepository Category => categoryRepository ?? new CategoryRepository(context);

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
