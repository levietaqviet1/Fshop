using FA.BookStore.Core.Repositories.IRenpositoty;

namespace FA.BookStore.Core.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IPublisherRepository PublisherRepository { get; }

        void SaveChange();
    }
}
