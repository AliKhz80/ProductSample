using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductDeliver : TrackableEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "50";
        public bool isIncreased { get; set; }
        public int StartCirculation { get; set; }
        public int EndCirculation { get; set; }
        public byte PrintSide { get; set; }
        public double Price { get; set; }
        public byte CalcType { get; set; }
        public Product Product { get; set; } = null!;
        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; } = [];

    }
}
