using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.Configuration
{
	internal class VenueConfig : IEntityTypeConfiguration<Venue>
	{
		public void Configure(EntityTypeBuilder<Venue> entity)
		{
			entity.HasData(
				new Venue { VenueId = 1, VenueName = "Venue Name 1", VenueAddress = "Venue Address 1", VenueContactInfo = "Venue Contact Info 1" },
				new Venue { VenueId = 2, VenueName = "Venue Name 2", VenueAddress = "Venue Address 2", VenueContactInfo = "Venue Contact Info 2" }
			);
		}
	}
}
