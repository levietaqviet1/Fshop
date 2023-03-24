using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;

namespace FA.BookStore.Core.Repositories.IRenpositoty
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        List<Comment> GetCommentsByBook(int bookId);
    }
}
