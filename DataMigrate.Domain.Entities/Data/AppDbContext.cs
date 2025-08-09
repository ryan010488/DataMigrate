using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Xml;
using DataMigrate.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace FiberStatus.Domain.Entities.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataMigrate.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            try
            {
                base.OnModelCreating(builder);

                builder.Entity<Treatment>()
                    .HasKey(e => e.PatientId);

                builder.Entity<Treatment>()
                    .HasKey(e => e.TreatmentId);

                builder.Entity<Invoice>()
                    .HasKey(e => e.InvoiceId);

                builder.Entity<InvoiceLineItem>()
                    .HasKey(e => e.InvoiceLineItemId);

                builder.Entity<InvoiceLineItem>()
                    .HasOne(b => b.Invoice)
                    .WithMany(a => a.InvoiceLineItems)
                    .HasForeignKey(b => b.InvoiceId);

                builder.Entity<Invoice>(entity =>
                {
                    entity.Property(e => e.InvoiceNo)
                        .ValueGeneratedOnAdd();
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
