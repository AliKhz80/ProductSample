using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductPrintKind:Entity
    {
        public int ProductId { get; set; }
        public int PrintKindId { get; set; }
        public bool IsJeld { get; set; }
    }
}
