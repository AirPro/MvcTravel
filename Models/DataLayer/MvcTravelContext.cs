using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcTravel.Models.DomainModels;

namespace MvcTravel.Models.DataLayer
{
	public class MvcTravelContext : DbContext
	{
		public MvcTravelContext(DbContextOptions<MvcTravelContext> options) : base(options) { }
		public DbSet<Event> Events { get; set; }
		
		public DbSet<Venue> Venues { get; set; }
		public DbSet<Promoter> Promoters { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Event: set primary key
			modelBuilder.Entity<Event>().HasKey(e => new { e.EventId });

			// Venue: set primary key
			modelBuilder.Entity<Venue>().HasKey(v => new { v.VenueId });

			// Promoter: set primary key
			modelBuilder.Entity<Promoter>().HasKey(p => new { p.PromoterId });
		}
	}
}
