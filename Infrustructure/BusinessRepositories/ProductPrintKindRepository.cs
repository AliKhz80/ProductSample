using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{

    public class ProductPrintKindRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductPrintKind>(productSampleDBContext, currentUser), IProductPrintKindRepository
    {
    }
}
