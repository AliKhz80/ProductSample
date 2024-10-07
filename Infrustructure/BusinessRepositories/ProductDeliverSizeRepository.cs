using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{
    public class ProductDeliverSizeRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductDeliverSize>(productSampleDBContext, currentUser), IProductDeliverSizeRepository
    {
    }
}
