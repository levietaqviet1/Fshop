using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.ImplementRepo
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookStoreContext context) : base(context)
        {
        }

        public Book FindBookByTitle(string title)
        {
            return context.Books.FirstOrDefault(x => x.Title.ToLower() == title.ToLower());
        }

        public Book FindBookBySummary(string summary)
        {
            return context.Books.FirstOrDefault(x => x.Summary.ToLower() == summary.ToLower());
        }

        public List<Book> GetLatesBook(int size)
        {
            return context.Books.OrderByDescending(b => b.CreateDate).Take(size).ToList();
        }

        public List<Book> GetBooksByMonth(DateTime monthYear)
        {
            return context.Books.Where(b => b.ModifiedDate.Month.Equals(monthYear.Month)).ToList();
        }

        public int CountBooksForCategory(string category)
        {
            return context.Books.Where(b => b.Category.CategoryName.ToLower() == category.ToLower()).Count();
        }

        public List<Book> GetBooksByCategory(string category)
        {
            return context.Books.Where(b => b.Category.CategoryName.ToLower() == category.ToLower()).ToList();
        }

        public int CountBooksForPublisher(string publisher)
        {
            return context.Books.Where(b => b.Publisher.Name.ToLower() == publisher.ToLower()).Count();
        }

        public List<Book> GetBooksByPublisher(string publisher)
        {
            return context.Books.Where(b => b.Publisher.Name.ToLower() == publisher.ToLower()).ToList();
        }
    }

}
