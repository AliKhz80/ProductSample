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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

           

           

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }



        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdt> ProductAdts { get; set; }
        public DbSet<ProductAdtPrice> ProductAdtPrices { get; set; }
        public DbSet<ProductAdtType> ProductAdtTypes { get; set; }
        public DbSet<ProductDeliver> ProductDelivers { get; set; }
        public DbSet<ProductDeliverSize> ProductDeliverSizes { get; set; }
        public DbSet<ProductJeld> ProductJelds { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductMaterialAttribute> ProductMaterialAttributes { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductPrintKind> ProductPrintKinds { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }

    }

}
