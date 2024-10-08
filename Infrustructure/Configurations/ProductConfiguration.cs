﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Circulation).HasColumnType("nvarchar(max)");
            builder.Property(p => p.CopyCount).HasColumnType("nvarchar(max)");
            builder.Property(p => p.PageCount).HasColumnType("nvarchar(max)");
            builder.Property(p => p.IsCalculatePrice).HasDefaultValueSql("1");
            builder.Property(p => p.FileExtension).HasColumnType("nvarchar(50)");
            builder.HasQueryFilter(p => p.IsDeleted == false);


        }
    }
}
