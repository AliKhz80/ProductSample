using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductSize : TrackableEntity
    {
        public int ProductId { get; set; }
        public double Length { get; set; }
        public double width { get; set; }
        public string Name { get; set; } = null!;
        public int? SheetCount { get; set; }
        public int? SheetDimensionId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; } = [];
        public virtual ICollection<ProductPrice> ProductPrices { get; set; } = [];
    }
}
