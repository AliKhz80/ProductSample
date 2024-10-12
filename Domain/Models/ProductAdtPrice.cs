using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdtPrice : TrackableEntity
    {
        public int ProductAdtId { get; set; }
        public double price { get; set; }
        public int ProductPriceId { get; set; }
        public int ProductAdtTypeId { get; set; }
        public virtual ProductAdt ProductAdt { get; set; } = null!;
        public virtual ProductPrice ProductPrice { get; set; } = null!;
        public virtual ProductAdtType ProductAdtType { get; set; } = null!;
    }
}
