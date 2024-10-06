using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductPrice : TrackableEntity
    {
        public double price { get; set; }
        public int Circulation { get; set; }
        public int IsDoubleSided { get; set; }
        public int? PageCount { get; set; }
        public int? copyCount { get; set; }
        public int ProductSizeId { get; set; }
        public int ProductMaterialId { get; set; }
        public int? ProductMaterialAttributeId { get; set; }
        public int IsJeld { get; set; }
        public int ProductPrintKindId { get; set; }
        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; } = [];
    }
}
