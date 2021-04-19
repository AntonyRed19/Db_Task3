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
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ProjectId");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(20);
            builder.Property(p => p.Badget).HasColumnName("Badget").HasColumnType("money");
            builder.Property(p => p.StartedDate).HasColumnName("StaredDate").HasColumnType("date");
        }
    }
}
