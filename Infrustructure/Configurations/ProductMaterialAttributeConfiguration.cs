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
    public class ProductMaterialAttributeConfiguration : IEntityTypeConfiguration<ProductMaterialAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductMaterialAttribute> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
