using System.Data;

namespace GeekShopping.Repository.Interface.UoW
{
    public interface IUnitOfWorkBase: IDisposable
    {
        IDbConnection Connection { get; set; }

        IDbTransaction Transaction { get; set; }

        IUnitOfWorkBase Create();

        IUnitOfWorkBase Create(IsolationLevel isolationLevel);

        void RollbackTransaction();
    }
}
