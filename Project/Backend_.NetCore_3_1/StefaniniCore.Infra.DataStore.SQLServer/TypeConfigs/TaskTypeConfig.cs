﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StefaniniCore.Domain.Entities;
using System;

namespace StefaniniCore.Infra.DataStore.SQLServer.TypeConfigs
{
    public class TaskTypeConfig : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            _ = builder.ToTable(nameof(Task));
            _ = builder.HasKey(g => g.Id);
            _ = builder.Property(g => g.Id).HasColumnName("Id");
            _ = builder.Property(g => g.Name).HasColumnName("Name").HasMaxLength(30).IsRequired();
            _ = builder.Property(g => g.IsActive).HasColumnName("Is_Active").IsRequired();

            _ = builder.Property(g => g.Date_Created)
                                .HasColumnName("Date_Created")
                                .HasColumnType((nameof(DateTime)).ToLower()).IsRequired();

            _ = builder.Property(g => g.Date_Updated)
                                .HasColumnName("Date_Updated")
                                .HasColumnType((nameof(DateTime)).ToLower()).IsRequired();

            _ = builder.HasIndex(g => g.Name).IsUnique();
        }
    }
}
