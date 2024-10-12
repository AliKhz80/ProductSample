using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdtType : Entity
    {
        public int ProductAdtId { get; set; }
        public int AdtTypeId { get; set; }
        public virtual ProductAdt ProductAdt { get; set; } = null!;
        public virtual ICollection<ProductAdtPrice> ProductAdtPrices { get; set; } = [];

    }
}
