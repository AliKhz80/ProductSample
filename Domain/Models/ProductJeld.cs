using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
