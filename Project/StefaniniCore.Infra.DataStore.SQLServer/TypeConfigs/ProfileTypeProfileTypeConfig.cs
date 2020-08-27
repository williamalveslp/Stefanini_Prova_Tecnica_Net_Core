using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StefaniniCore.Domain.Entities;
using System;

namespace StefaniniCore.Infra.DataStore.SQLServer.TypeConfigs
{
    public class ProfileTypeProfileTypeConfig : IEntityTypeConfiguration<ProfileType>
    {
        public void Configure(EntityTypeBuilder<ProfileType> builder)
        {
            _ = builder.ToTable(nameof(ProfileType));
            _ = builder.HasKey(g => g.Id);
            _ = builder.Property(g => g.Id).HasColumnName("Id");
            _ = builder.Property(g => g.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            _ = builder.Property(g => g.IsActive).HasColumnName("Is_Active").IsRequired();

            _ = builder.Property(e => e.Date_Created)
                                .HasColumnName("Date_Created")
                                .HasColumnType("datetime").IsRequired();

            _ = builder.Property(e => e.Date_Updated)
                                .HasColumnName("Date_Updated")
                                .HasColumnType("datetime").IsRequired();

            _ = builder.HasIndex(g => g.Name).IsUnique();
        }
    }
}
