﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repository.GenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        /// <summary>
        /// Create TEntity
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);

        void CreateRange(TEntity entity);

        void Update(TEntity entity);   

        void UpdateRange(TEntity entity);

        void Delete(TEntity entity);

        void Delete(int id);

        IEnumerable<TEntity> GetAll();

        TEntity Find(int id);

    }
}
