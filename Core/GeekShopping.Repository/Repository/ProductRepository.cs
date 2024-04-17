using GeekShopping.Entity;
using GeekShopping.Repository.GenericRepository;
using GeekShopping.Repository.Interface;
using GeekShopping.Repository.Interface.UoW;

namespace GeekShopping.Repository.Repository
{
    public class ProductRepository : RepositoryAsync<Product>, IProductRepository
    {
        private readonly IUnitOfWorkBase _unitOfWorkBase;

        public ProductRepository(IUnitOfWorkBase unitOfWorkBase): base(unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }

        public IEnumerable<Product> GetProducts(string description)
        {
            throw new NotImplementedException();
        }
    }
}
