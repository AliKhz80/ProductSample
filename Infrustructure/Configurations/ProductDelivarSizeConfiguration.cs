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
    public class ProductDelivarSizeConfiguration : IEntityTypeConfiguration<ProductDeliverSize>
    {
        public void Configure(EntityTypeBuilder<ProductDeliverSize> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
