using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductJeld : TrackableEntity
    {
        public int ProductId { get; set; }
        public byte PrintSide { get; set; }
        public string FileExtension { get; set; } = string.Empty;
        public bool IsCmyk { get; set; }
        public double? CutMargin { get; set; }
        public double? PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }
        public Product Product { get; set; } = null!;
    }
}
