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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);
            builder.Property(ep => ep.Id).HasColumnName("EmployeeId");
            builder.Property(ep => ep.Rate).IsRequired().HasColumnName("Rate").HasColumnType("money");
            builder.Property(ep => ep.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2(7)");
            builder.HasOne(ep => ep.Project)
               .WithMany(ep => ep.EmployeeProjects)
               .HasForeignKey(ep => ep.ProjectId)
               .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ep => ep.Employee)
              .WithMany(ep => ep.EmployeeProjects)
              .HasForeignKey(ep => ep.EmployeeId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
