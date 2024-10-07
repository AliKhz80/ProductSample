using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{

    public class ProductAdtRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
        Repository<ProductAdt>(productSampleDBContext, currentUser), IProductAdtRepository
    {
    }
}
