using FA.BookStore.Core.DataContext;
using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories.GennericRepo;
using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.ImplementRepo
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    { 
        public PublisherRepository(BookStoreContext context) : base(context) { }
    }
}
