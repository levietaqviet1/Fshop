using NWEB.Practice.T01.DataAccessLayer.Repositories;

namespace NWEB.Practice.T01.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IFlowerRepository FlowerRepository { get; }

        void SaveChange();
    }
}
