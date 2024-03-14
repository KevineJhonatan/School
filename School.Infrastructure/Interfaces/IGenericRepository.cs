namespace School.Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T entity);

        IQueryable<T> Find(int? id = null);

        void Update(T entity);

        void Delete(int id);

        void Commit();

        IList<T> ExecuteStoredProcedure(string procedure, params object[] args);
    }
}
