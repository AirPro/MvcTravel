using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MvcTravel.Models.Configuration;
using MvcTravel.Models.DomainModels;

namespace MvcTravel.Models.DataLayer
{
    public partial class MvcTravelContext : DbContext
    {
        public MvcTravelContext()
        {
        }

        public MvcTravelContext(DbContextOptions<MvcTravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Promoter> Promoter { get; set; }
        public virtual DbSet<Venue> Venue { get; set; }

        //This code supports the HomeController.cs combination of all 3 tables (25, 26, 27)
		public object Events { get; internal set; }
		public object Venues { get; internal set; }
		public object Promoters { get; internal set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).ValueGeneratedNever();

                entity.Property(e => e.EventCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Promoter>(entity =>
            {
                entity.Property(e => e.PromoterId).ValueGeneratedNever();

                entity.Property(e => e.PromoterAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoterContactInfo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Promoter)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)  // change .ClientSetNull to .Restrict if fails
                    .HasConstraintName("FK_Promoter_Event");
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.Property(e => e.VenueId).ValueGeneratedNever();

                entity.Property(e => e.VenueAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenueContactInfo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
