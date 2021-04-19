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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("User").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ProjectId");
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(20);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(20);
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate").HasColumnType("smalldatetime");
        }
    }
}
