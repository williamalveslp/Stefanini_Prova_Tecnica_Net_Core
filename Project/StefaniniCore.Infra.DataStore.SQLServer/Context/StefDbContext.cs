using Microsoft.EntityFrameworkCore;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Infra.DataStore.SQLServer.TypeConfigs;

namespace StefaniniCore.Infra.DataStore.SQLServer
{
    public partial class StefDbContext : DbContext
    {
        public StefDbContext()
        {
        }

        public StefDbContext(DbContextOptions<StefDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProfileType> ProfileType { get; set; }
        public virtual DbSet<ProfileTypeTask> ProfileTypeTask { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<UserSystem> UserSystem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO: Move this connection string to configuration file.
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=StefDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new ProfileTypeProfileTypeConfig());

            modelBuilder.Entity<ProfileType>(entity =>
            {
                entity.ToTable("Profile_Type");

                entity.Property(e => e.Date_Created)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date_Updated)
                    .HasColumnName("Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            // modelBuilder.ApplyConfiguration(new ProfileTypeTaskTypeConfig());
            modelBuilder.Entity<ProfileTypeTask>(entity =>
            {
                entity.ToTable("Profile_Type_Task");

                entity.Property(e => e.ProfileTypeId).HasColumnName("Profile_Type_Id");

                entity.Property(e => e.TaskId).HasColumnName("Task_Id");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.ProfileTypeTask)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Profile_Type_Profile_TypeFk");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ProfileTypeTask)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Profile_Type_TaskFk");
            });

            // modelBuilder.ApplyConfiguration(new TaskTypeConfig());
            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Date_Created)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date_Updated)
                    .HasColumnName("Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            //modelBuilder.ApplyConfiguration(new UserSystemTypeConfig());
            modelBuilder.Entity<UserSystem>(entity =>
            {
                entity.ToTable("User_System");

                entity.Property(e => e.Date_Created)
                    .HasColumnName("Date_Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date_Updated)
                    .HasColumnName("Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTypeId).HasColumnName("Profile_Type_Id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("User_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.UserSystem)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_System_Profile_TypeFk");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
