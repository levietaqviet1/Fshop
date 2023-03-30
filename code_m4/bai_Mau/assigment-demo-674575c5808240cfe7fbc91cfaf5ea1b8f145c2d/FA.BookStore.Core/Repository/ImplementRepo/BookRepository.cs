using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repository.GenericRepo;
using FA.BookStore.Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.ImplementRepo
{
    public class BookRepository: GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookStoreContext context):base(context)
        {
        }

        public Book FindBookByTitle(string title)
        {
            return context.Books.FirstOrDefault(x => x.Title.ToLower() == title.ToLower());
        }
    }
}
