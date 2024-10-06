using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductMaterial : TrackableEntity
    {
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public string? Name { get; set; }
        public bool IsJeld { get; set; }
        public bool Required { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCombinedMaterial { get; set; }
        public int Weight { get; set; }
        public Product Product { get; set; } = null!;
        public ICollection<ProductMaterialAttribute> ProductMaterialAttributes { get; set; } = [];
    }
}
