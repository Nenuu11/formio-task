namespace IntalioTask.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllBind();
        Task<IEnumerable<TEntity>> GetAllBindAsync();

        TEntity GetById(params object[] id);
        Task<TEntity> GetByIdAsync(params object[] id);

        TEntity Add(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);

        bool Remove(TEntity entity);
        Task<bool> RemoveAsync(TEntity entity);

        bool Update(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
    }
}
