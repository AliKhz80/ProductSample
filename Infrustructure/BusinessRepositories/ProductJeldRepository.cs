using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.BusinessRepositories
{
    public class ProductJeldRepository(ProductSampleDBContext productSampleDBContext, ICurrentUser currentUser) :
    Repository<ProductJeld>(productSampleDBContext, currentUser), IProductJeldRepository
    {
    }
}
