﻿using Microsoft.EntityFrameworkCore;
using NWEB.Practice.T01.Core.DataContext;

namespace NWEB.Practice.T01.DataAccessLayer.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly FlowerShopContext _context;
        protected DbSet<T> dbSet;
        public GenericRepository(FlowerShopContext flowerShopContext = null)
        {
            this._context = flowerShopContext ?? new FlowerShopContext();
            dbSet = _context.Set<T>();
        }

        /// <summary>
        /// thêm 1 object vào danh sách
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// xóa object khỏi danh sách
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// xóa object theo id object
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            T obj = Find(id);
            Delete(obj);
        }



        /// <summary>
        /// tìm object theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Find(int id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (Exception)
            {

                return null;
            }

        }

        /// <summary>
        /// trả về danh sách các object
        /// </summary>
        /// <returns></returns>
        public IList<T> GetAll()
        {
            return dbSet.ToList();
        }

        /// <summary>
        /// update object
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}