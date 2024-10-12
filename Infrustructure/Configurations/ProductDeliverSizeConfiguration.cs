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
    public class ProductDeliverSizeConfiguration : IEntityTypeConfiguration<ProductDeliverSize>
    {
        public void Configure(EntityTypeBuilder<ProductDeliverSize> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .HasOne(p => p.ProductSize)
                .WithMany(p => p.ProductDeliverSizes)
                .HasForeignKey(p => p.ProductSizeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
