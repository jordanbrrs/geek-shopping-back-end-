namespace GeekShopping.Repository.Interface.UoW
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        IProductRepository ProductRepository { get; }
    }
}
