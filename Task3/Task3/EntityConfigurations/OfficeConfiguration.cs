using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task3.Entities;

namespace Task3.EntityConfigurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("TitleId");
            builder.Property(o => o.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
        }
    }
}
