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
    public class ProductJeldConfiguration : IEntityTypeConfiguration<ProductJeld>
    {
        public void Configure(EntityTypeBuilder<ProductJeld> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FileExtension).HasColumnType("nvarchar(50)");
            builder.HasQueryFilter(p => p.IsDeleted == false);


        }
    }
}
