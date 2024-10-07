using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;

namespace Infrustructure.BusinessRepositories
{
    public class ProductRepository(ProductSampleDBContext productSampleDBContext , ICurrentUser currentUser) :
        Repository<Product>(productSampleDBContext , currentUser) , IProductRepository
    {
    }
}
