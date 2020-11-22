using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.Configuration
{
	internal class EventConfig : IEntityTypeConfiguration<Event>
	{
		public void Configure(EntityTypeBuilder<Event> entity)
		{
			
			entity.HasData(
				new Event { EventId = 1, EventName = "Test Name One", EventCity = "Test City One", EventDate = new DateTime(20200501)},
				new Event { EventId = 2, EventName = "Test Name Two", EventCity = "Test City Two", EventDate = new DateTime(20200617)}
			);
			
		}
	}
}
