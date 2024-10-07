using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{

    public class ProductDeliverRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductDeliver>(productSampleDBContext, currentUser), IProductDeliverRepository
    {
    }
}
