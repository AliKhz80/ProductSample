using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductDeliverSize : Entity
    {
        public int ProductSizeId { get; set; }
        public int ProductDeliverId { get; set; }
        public ProductSize ProductSize { get; set; } = null!;
        public ProductDeliver ProductDeliver { get; set; } = null!;
    }
}
