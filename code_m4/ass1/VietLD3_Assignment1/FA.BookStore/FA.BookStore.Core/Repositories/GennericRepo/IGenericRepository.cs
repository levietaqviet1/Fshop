namespace FA.BookStore.Core.Repositories.GennericRepo
{
    public interface IGenericRepository<TEntity> where TEntity : class
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
