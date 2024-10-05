using Domain.ModelConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductDeliver :Entity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public bool isIncreased { get; set; }
        public int StartCirculation { get; set; }
        public int EndCirculation { get; set; }
        public byte PrintSide { get; set; }
        public double Price { get; set; }
        public byte CalcType { get; set; }
    }
}
