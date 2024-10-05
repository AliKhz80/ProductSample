using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductSize : TrackableEntity
    {
        public int ProductId { get; set; }
        public double Length { get; set; }
        public double width { get; set; }
        public string Name { get; set; }
        public int? SheetCount { get; set; }
        public int? SheetDimensionId { get; set; }
    }
}
