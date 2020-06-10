using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Infra.DataStore.SQLServer.TypeConfigs
{
    public class UserSystemTypeConfig : IEntityTypeConfiguration<UserSystem>
    {
        public void Configure(EntityTypeBuilder<UserSystem> builder)
        {
            _ = builder.ToTable(nameof(UserSystem));
            _ = builder.HasKey(g => g.Id);
            _ = builder.Property(g => g.Id).HasColumnName("Id");
            _ = builder.Property(g => g.UserName).HasColumnName("User_Name").HasMaxLength(30).IsRequired();
            _ = builder.Property(g => g.Password).HasColumnName("Password").HasMaxLength(30).IsRequired();
            _ = builder.Property(g => g.IsActive).HasColumnName("Is_Active").IsRequired();

            _ = builder.Property(g => g.Date_Created)
                                .HasColumnName("Date_Created")
                                .HasColumnType("datetime").IsRequired();

            _ = builder.Property(g => g.Date_Updated)
                                .HasColumnName("Date_Updated")
                                .HasColumnType("datetime").IsRequired();

            _ = builder.HasIndex(g => g.UserName).IsUnique();
        }
    }
}
