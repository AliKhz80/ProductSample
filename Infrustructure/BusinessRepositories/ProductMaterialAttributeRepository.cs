using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{
    public class ProductMaterialAttributeRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductMaterialAttribute>(productSampleDBContext, currentUser), IProductMaterialAttributeRepository
    {
    }
}
