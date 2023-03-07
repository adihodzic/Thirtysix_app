using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Thirtysix_app.WebAPI.Database;

namespace Thirtysix_app.Database
{
    public partial class eBicikliContext : DbContext
    {
        public eBicikliContext()
        {
        }

        public eBicikliContext(DbContextOptions<eBicikliContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bicikli> Bicikli { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=eProdaja; user=sa; Password=QWEasd123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<Bicikli>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Bicikli");


                entity.Property(e => e.Naziv).HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.TipBicikla).HasMaxLength(25);

                
            });

           
            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
