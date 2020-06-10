using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Infra.DataStore.SQLServer.TypeConfigs
{
    public class ProfileTypeTaskTypeConfig : IEntityTypeConfiguration<ProfileTypeTask>
    {
        public void Configure(EntityTypeBuilder<ProfileTypeTask> builder)
        {
            _ = builder.ToTable(nameof(ProfileTypeTask));
            _ = builder.HasKey(g => g.Id);
            _ = builder.Property(g => g.Id).HasColumnName("Id");
            _ = builder.Property(g => g.ProfileTypeId).HasColumnName("Profile_Type_Id");
            _ = builder.Property(g => g.TaskId).HasColumnName("Task_Id").IsRequired();

            _ = builder.HasOne(d => d.ProfileType)
                        .WithMany(p => p.ProfileTypeTask)
                        .HasForeignKey(d => d.ProfileTypeId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Profile_Type_Profile_TypeFk");

            _ = builder.HasOne(d => d.Task)
                        .WithMany(p => p.ProfileTypeTask)
                        .HasForeignKey(d => d.TaskId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Profile_Type_TaskFk");
        }
    }
}
