using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.ImplementRepo
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreContext context) : base(context) { }
    }

}
