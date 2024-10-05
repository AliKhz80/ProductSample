using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Infrustructure
{
    public class ProductSampleDBContext : DbContext
    {
    
        public ProductSampleDBContext(DbContextOptions<ProductSampleDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
       

    }

}
