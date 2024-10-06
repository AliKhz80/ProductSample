using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdtType : Entity
    {
        public int ProductAdtId { get; set; }
        public int AdtTypeId { get; set; }
        public ProductAdt ProductAdt { get; set; } = null!;
        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; } = [];

    }
}
