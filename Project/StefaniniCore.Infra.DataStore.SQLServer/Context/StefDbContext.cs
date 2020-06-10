﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.ApplyConfiguration(new ProfileTypeProfileTypeConfig());
            modelBuilder.ApplyConfiguration(new ProfileTypeTaskTypeConfig());
            modelBuilder.ApplyConfiguration(new TaskTypeConfig());
            modelBuilder.ApplyConfiguration(new UserSystemTypeConfig());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
