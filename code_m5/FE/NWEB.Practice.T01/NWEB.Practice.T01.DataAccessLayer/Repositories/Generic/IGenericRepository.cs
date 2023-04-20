namespace NWEB.Practice.T01.DataAccessLayer.Repositories.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        public T Find(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        IList<T> GetAll();

    }
}
