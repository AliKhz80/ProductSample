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
    public class ProductPrintKindConfiguration : IEntityTypeConfiguration<ProductPrintKind>
    {
        public void Configure(EntityTypeBuilder<ProductPrintKind> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
