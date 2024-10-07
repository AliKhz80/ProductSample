using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{

    public class ProductSizeRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductSize>(productSampleDBContext, currentUser), IProductSizeRepository
    {
    }
}

