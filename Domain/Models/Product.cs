using Domain.ModelConfigs;

namespace Domain.Models
{
    public class Product : TrackableEntity
    {
        public int ProductGroupId { get; set; }
        public int WorkTypeId { get; set; }
        public byte ProductType { get; set; }
        public string? Circulation { get; set; }
        public string? CopyCount { get; set; }
        public string? PageCount { get; set; }
        public byte PrintSide { get; set; }
        public bool IsCalculatePrice { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCustomSize { get; set; }
        public int? IsCustomPage { get; set; }
        public int? MinCirculation { get; set; }
        public int? MaxCirculation { get; set; }
        public int? MinPage { get; set; }
        public int? MaxPage { get; set; }
        public double? MinWidth { get; set; }
        public double? MaxWidth { get; set; }
        public double? MinLength { get; set; }
        public double? MaxLength { get; set; }
        public int SheetDimensionId { get; set; }
        public string FileExtension { get; set; } = null!;
        public bool IsCmyk { get; set; }
        public double CutMargin { get; set; }
        public double PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }
        public virtual ICollection<ProductAdt> ProductAdts { get; set; } = [];
        public virtual ICollection<ProductDeliver> ProductDelivers { get; set; } = [];
        public virtual ICollection<ProductJeld> ProductJelds { get; set; } = [];
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = [];
        public virtual ICollection<ProductPrintKind> ProductPrintKinds { get; set; } = [];
        public virtual ICollection<ProductSize> ProductSizes { get; set; } = [];

    }
}
