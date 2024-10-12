using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductJeld : TrackableEntity
    {
        public int ProductId { get; set; }
        public byte PrintSide { get; set; }
        public string FileExtension { get; set; } = null!;
        public bool IsCmyk { get; set; }
        public double? CutMargin { get; set; }
        public double? PrintMargin { get; set; }
        public bool IsCheckFile { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
