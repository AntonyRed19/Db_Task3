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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ClientId");
            builder.Property(c => c.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).IsRequired().HasColumnName("HiredDate").HasMaxLength(13);
            builder.Property(c => c.DateofBith).HasColumnName("DateofBirth").HasColumnType("date");
        }
    }
}
