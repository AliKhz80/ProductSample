using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Configurations
{
    public class ProductAdtPriceConfiguration : IEntityTypeConfiguration<ProductAdtPrice>
    {
        public void Configure(EntityTypeBuilder<ProductAdtPrice> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasQueryFilter(p => p.IsDeleted == false);

        }
    }
}
