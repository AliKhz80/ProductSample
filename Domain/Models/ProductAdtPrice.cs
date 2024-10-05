using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductAdtPrice : Entity
    {
        public int ProductAdtId { get; set; }
        public double price { get; set; }
        public int ProductPriceId { get; set; }
        public int ProductAdtTypeId { get; set; }
    }
}
