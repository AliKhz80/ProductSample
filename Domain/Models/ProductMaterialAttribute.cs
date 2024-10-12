using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductMaterialAttribute : Entity
    {
        public int ProductMaterialId { get; set; }
        public int MaterialAttributeId { get; set; }
        public virtual ProductMaterial ProductMaterial { get; set; } = null!;
        public virtual ICollection<ProductPrice> ProductPrices { get; set; } = [];


    }
}
