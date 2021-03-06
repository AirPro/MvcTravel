﻿using MvcTravel.Models.DomainModels;

namespace MvcTravel.Models.DataLayer
{
	public class ClassMvcTravelUnitOfWork : IClassMvcTravelUnitOfWork
	{
		private MvcTravelContext context { get; set; }
		public ClassMvcTravelUnitOfWork(MvcTravelContext ctx) => context = ctx;

		private Repository<Event> eventData;
		public Repository<Event> Events
		{
			get
			{
				if (eventData == null)
					eventData = new Repository<Event>(context);
				return eventData;
			}
		}

		private Repository<Venue> venueData;
		public Repository<Venue> Venues
		{
			get
			{
				if (venueData == null)
					venueData = new Repository<Venue>(context);
				return venueData;
			}
		}

		private Repository<Promoter> promoterData;
		public Repository<Promoter> Promoters
		{
			get
			{
				if (promoterData == null)
					promoterData = new Repository<Promoter>(context);
				return promoterData;
			}
		}

		public void Save() => context.SaveChanges();
	}
}
