using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Infrustructure.BusinessRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrustructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductSampleDBContext _context;

        public UnitOfWork(
            ProductSampleDBContext context,
            IProductRepository _productRepository,
            IProductAdtRepository _productAdtRepository,
            IProductAdtPriceRepository _productAdtPriceRepository,
            IProductAdtTypeRepository _productAdtTypeRepository,
            IProductDeliverRepository _productDeliverRepository,
            IProductDeliverSizeRepository _productDeliverSizeRepository,
            IProductJeldRepository _productJeldRepository,
            IProductMaterialRepository _productMaterialRepository,
            IProductMaterialAttributeRepository _productMaterialAttributeRepository,
            IProductPriceRepository _productPriceRepository,
            IProductPrintKindRepository _productPrintKindRepository,
            IProductSizeRepository _productSizeRepository
            )
        {
            productRepository = _productRepository;
            productAdtRepository = _productAdtRepository;
            productAdtPriceRepository = _productAdtPriceRepository;
            productAdtTypeRepository = _productAdtTypeRepository;
            productDeliverRepository = _productDeliverRepository;
            productDeliverSizeRepository = _productDeliverSizeRepository;
            productJeldRepository =_productJeldRepository;
            productMaterialRepository = _productMaterialRepository;
            productMaterialAttributeRepository = _productMaterialAttributeRepository;
            productPriceRepository = _productPriceRepository;
            productPrintKindRepository = _productPrintKindRepository;
            productSizeRepository = _productSizeRepository;
            _context = context;

        } 
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


        public void Commit() => _context.SaveChanges();

        public void Rollback() => _context.Database.RollbackTransaction();// Rollback changes if needed

        public async Task RollbackAsync() => await _context.Database.RollbackTransactionAsync();

        public async Task CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();

        public async Task BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();

        public async Task CommitTransactionAsync() => await _context.Database.CommitTransactionAsync();

        public void CommitTransaction() =>  _context.Database.CommitTransaction();

    }
}
