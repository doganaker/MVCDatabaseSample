using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje2.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.Configurations
{
    public class OrderDetailConfiguration
    {
        public class CategoryConfiguration : IEntityTypeConfiguration<OrderDetail>
        {
            public void Configure(EntityTypeBuilder<OrderDetail> builder)
            {
                builder.HasKey(q => q.OrderID);
                builder.HasKey(q => q.ProductID);

                builder.Property(q => q.UnitPrice)
                    .HasColumnType("money");

               
            }
        }
    }
}
