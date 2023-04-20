using NWEB.Practice.T01.Core.DataContext;
using NWEB.Practice.T01.Core.Repositories.Impl;
using NWEB.Practice.T01.DataAccessLayer.Repositories;
using NWEB.Practice.T01.DataAccessLayer.Repositories.Impl;

namespace NWEB.Practice.T01.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlowerShopContext _context;
        private ICategoryRepository _categoryRepository;
        private IFlowerRepository _flowerRepository;

        public UnitOfWork(FlowerShopContext context = null)
        {
            this._context = context ?? new FlowerShopContext();
        }
        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);

        public IFlowerRepository FlowerRepository => _flowerRepository ?? new FlowerRepository(_context);
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();

                }
            }
            this.disposed = true;
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
