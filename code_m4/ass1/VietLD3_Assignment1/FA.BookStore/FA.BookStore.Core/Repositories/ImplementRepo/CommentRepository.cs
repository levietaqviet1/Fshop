using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.ImplementRepo
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BookStoreContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByBook(int bookId)
        {
            return context.Comments.Where(c => c.BookId == bookId && c.IsActice).ToList();
        }
    }
}
