using Dapper.Contrib.Extensions;
using GeekShopping.Repository.Interface.GenericRepository;
using GeekShopping.Repository.Interface.UoW;

namespace GeekShopping.Repository.GenericRepository
{
    public class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class, new()
    {
        private readonly IUnitOfWorkBase _uow;

        public RepositoryAsync(
            IUnitOfWorkBase unitOfWorkBase)
        {
            _uow = unitOfWorkBase;
        }

        public async virtual Task<IEnumerable<TEntity>> GetAll()
        {
            IEnumerable<TEntity> all = await _uow.Connection.GetAllAsync<TEntity>(_uow.Transaction);
            return all;
        }

        public async virtual Task<TEntity> Get(long id)
        {
            TEntity entity = await _uow.Connection.GetAsync<TEntity>(id, _uow.Transaction);
            return entity;
        }

        public async virtual Task<long> Insert(TEntity entity)
        {
            long identity = await _uow.Connection.InsertAsync(entity, _uow.Transaction);
            return identity;
        }

        public async virtual Task<IEnumerable<long>> InsertMany(IEnumerable<TEntity> entities)
        {
            IList<long> identities = new List<long>();

            foreach (var entity in entities)
            {
                long identity = 0;
                identity = await _uow.Connection.InsertAsync(entity, _uow.Transaction);

                identities.Add(identity);
            }

            return identities;
        }

        public async virtual Task<TEntity> Update(TEntity entity)
        {
            await _uow.Connection.UpdateAsync(entity, _uow.Transaction);

            return entity;
        }

        public async virtual Task<bool> Delete(TEntity entity)
        {
            bool success = false;

            success = await _uow.Connection.DeleteAsync(entity, _uow.Transaction);

            return success;
        }

        public async virtual Task<TEntity> InsertOrUpdate(TEntity entity, long pk)
        {
            if (pk == 0)
            {
                await Insert(entity);
            }
            else
            {
                TEntity entityDatabase = await Get(pk);

                if (entityDatabase != null)
                {
                    await Update(entity);
                }
            }

            return entity;
        }
    }
}
