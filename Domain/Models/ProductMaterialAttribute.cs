using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductMaterialAttribute : Entity
    {
        public int ProductMaterialId { get; set; }
        public int MaterialAttributeId { get; set; }
    }
}
