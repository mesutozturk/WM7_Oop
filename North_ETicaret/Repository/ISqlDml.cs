namespace North_ETicaret.Repository
{
    public interface ISqlDml<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        int Save();
    }
}
