using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje2.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(q => q.CategoryID);


            builder.Property(q => q.CategoryName)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(q => q.Picture).HasColumnType("image");
        }
    }
}
