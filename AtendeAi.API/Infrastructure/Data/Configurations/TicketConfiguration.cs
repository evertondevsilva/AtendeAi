﻿using AtendeAi.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AtendeAi.API.Infrastructure.Data.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");
            builder.Property(t => t.TicketNumber)
                .HasMaxLength(16)
                .IsRequired();
            builder.Property(t => t.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.Description)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}


