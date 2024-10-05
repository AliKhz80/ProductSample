using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdt : Entity
    {
        public int AdtId { get; set; }
        public int ProductId { get; set; }
        public bool Required { get; set; }
        public byte? Side { get; set; }
        public int? Count { get; set; }
        public bool IsJeld { get; set; }
    }
}
