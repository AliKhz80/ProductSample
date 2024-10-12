using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductDeliver : TrackableEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public bool isIncreased { get; set; }
        public int StartCirculation { get; set; }
        public int EndCirculation { get; set; }
        public byte PrintSide { get; set; }
        public double Price { get; set; }
        public byte CalcType { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; } = [];

    }
}
