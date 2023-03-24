using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;

namespace FA.BookStore.Core.Repositories.IRenpositoty
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Book FindBookByTitle(string title);
        Book FindBookBySummary(string summary);
        List<Book> GetLatesBook(int size);
        List<Book> GetBooksByMonth(DateTime monthYear);
        int CountBooksForCategory(string category);
        List<Book> GetBooksByCategory(string category);
        int CountBooksForPublisher(string publisher);
        List<Book> GetBooksByPublisher(string publisher);
    }

}
