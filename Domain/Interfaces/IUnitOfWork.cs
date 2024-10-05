
namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

       

        void Commit();

        public Task CommitAsync();

        void Rollback();

        public Task RollbackAsync();

        public Task BeginTransactionAsync();

    }
}
