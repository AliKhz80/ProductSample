using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Configurations
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            builder
               .HasOne(p => p.ProductPrintKind)
               .WithMany(p => p.ProductPrices)
               .HasForeignKey(p => p.ProductPrintKindId)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder
              .HasOne(p => p.ProductSize)
              .WithMany(p => p.ProductPrices)
              .HasForeignKey(p => p.ProductSizeId)
              .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
