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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmployeeId");
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HiredDate").HasColumnType("datetime2(7)");
            builder.Property(e => e.DateofBirth).HasColumnName("DateofBirth").HasColumnType("date");
            builder.HasOne(e => e.Title)
               .WithMany(e => e.Employees)
               .HasForeignKey(e => e.TitleId)
               .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Office)
              .WithMany(e => e.Employees)
              .HasForeignKey(e => e.OfficeId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
