using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductAdtType : Entity
    {
        public int ProductAdtId { get; set; }
        public int AdtTypeId { get; set; }
    }
}
