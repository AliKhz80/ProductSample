using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductDeliverSize : Entity
    {
        public int ProductSizeId { get; set; }
        public int ProductDeliverId { get; set; }
    }
}
