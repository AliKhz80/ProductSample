using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductPrintKind:Entity
    {
        public int ProductId { get; set; }
        public int PrintKindId { get; set; }
        public bool IsJeld { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ProductPrice> ProductPrices { get; set; } = [];


    }
}
