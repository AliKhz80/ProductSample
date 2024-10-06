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
    public class ProductAdtTypeConfiguration : IEntityTypeConfiguration<ProductAdtType>
    {
        public void Configure(EntityTypeBuilder<ProductAdtType> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
