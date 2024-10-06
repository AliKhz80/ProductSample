using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductSize : TrackableEntity
    {
        public int ProductId { get; set; }
        public double Length { get; set; }
        public double width { get; set; }
        public string Name { get; set; }
        public int? SheetCount { get; set; }
        public int? SheetDimensionId { get; set; }
        public Product Product { get; set; } = null!;
        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; } = [];
    }
}
