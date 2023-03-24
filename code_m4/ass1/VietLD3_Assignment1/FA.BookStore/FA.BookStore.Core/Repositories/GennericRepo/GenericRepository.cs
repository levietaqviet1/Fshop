using FA.BookStore.Core.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Core.Repositories.GennericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly BookStoreContext context;
        protected DbSet<TEntity> dbSet;

        public GenericRepository(BookStoreContext context = null)
        {
            this.context = context ?? new BookStoreContext();
            dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
            //context.Entry<TEntity>(entity).State = EntityState.Added;
        }

        public void CreateRange(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
           TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public TEntity Find(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

}
