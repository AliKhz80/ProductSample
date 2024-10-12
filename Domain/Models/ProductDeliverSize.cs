using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductDeliverSize : Entity
    {
        public int ProductSizeId { get; set; }
        public int ProductDeliverId { get; set; }
        public virtual ProductSize ProductSize { get; set; } = null!;
        public virtual ProductDeliver ProductDeliver { get; set; } = null!;
    }
}
