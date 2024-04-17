namespace GeekShopping.Repository.Interface.GenericRepository
{
    public interface IRepositoryAsync<TEntity> where TEntity : class, new()
    {
        Task<TEntity> Get(long id);        
        Task<long> Insert(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Update(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<TEntity> InsertOrUpdate(TEntity entity, long pk);
        Task<IEnumerable<long>> InsertMany(IEnumerable<TEntity> entities);
    }
}
