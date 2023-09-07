using GeekShopping.Entity;

namespace GeekShopping.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string description);
    }
}
