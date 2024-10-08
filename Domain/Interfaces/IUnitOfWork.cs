
using Domain.Interfaces.BusinessIRepositories;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

       public IProductRepository productRepository { get; }
       public IProductAdtRepository productAdtRepository { get; }
       public IProductAdtPriceRepository productAdtPriceRepository { get; }
       public IProductAdtTypeRepository productAdtTypeRepository { get; }
       public IProductDeliverRepository productDeliverRepository { get; }
       public IProductDeliverSizeRepository productDeliverSizeRepository { get; }
       public IProductJeldRepository productJeldRepository { get; }
       public IProductMaterialRepository productMaterialRepository { get; }
       public IProductMaterialAttributeRepository productMaterialAttributeRepository { get; }
       public IProductPriceRepository productPriceRepository { get; }
       public IProductPrintKindRepository productPrintKindRepository { get; }
       public IProductSizeRepository productSizeRepository { get; }


        public void Commit();

        public Task CommitAsync();

        public void Rollback();

        public Task RollbackAsync();

        public Task BeginTransactionAsync();
        public Task CommitTransactionAsync();
        public void CommitTransaction();

    }
}
