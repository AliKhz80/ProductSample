using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{

    public class ProductMaterialRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductMaterial>(productSampleDBContext, currentUser), IProductMaterialRepository
    {
    }
}
