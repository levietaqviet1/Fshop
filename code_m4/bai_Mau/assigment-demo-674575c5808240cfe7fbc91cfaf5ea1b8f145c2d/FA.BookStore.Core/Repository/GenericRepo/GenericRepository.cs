using FA.BookStore.Core.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.GenericRepo
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void UpdateRange(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
