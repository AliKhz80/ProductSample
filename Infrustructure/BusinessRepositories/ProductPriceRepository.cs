using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{
    public class ProductPriceRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductPrice>(productSampleDBContext, currentUser), IProductPriceRepository
    {
    }
}
