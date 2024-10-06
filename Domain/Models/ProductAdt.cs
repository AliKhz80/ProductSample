﻿using Domain.ModelConfigs;

namespace Domain.Models
{
    public class ProductAdt : TrackableEntity
    {
        public int AdtId { get; set; }
        public int ProductId { get; set; }
        public bool Required { get; set; }
        public byte? Side { get; set; }
        public int? Count { get; set; }
        public bool IsJeld { get; set; }
        public Product Product { get; set; } = null!;
        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; } = null!;
        public ICollection<ProductAdtType> ProductAdtTypes { get; set; } = null!;

    }
}
