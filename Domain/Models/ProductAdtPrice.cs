using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdtPrice : TrackableEntity
    {
        public int ProductAdtId { get; set; }
        public double price { get; set; }
        public int ProductPriceId { get; set; }
        public int ProductAdtTypeId { get; set; }
        public ProductAdt ProductAdt { get; set; } = null!;
        public ProductPrice ProductPrice { get; set; } = null!;
        public ProductAdtType ProductAdtType { get; set; } = null!;
    }
}
