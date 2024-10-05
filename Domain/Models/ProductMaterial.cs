using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
