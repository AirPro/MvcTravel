
using MvcTravel.Models.DomainModels;

namespace MvcTravel.Models.DataLayer
{
	public interface IClassMvcTravelUnitOfWork
	{
		public Repository<Event> Events { get; }
		public Repository<Venue> Venues { get; }
		public Repository<Promoter> Promoters { get; }

		public void Save();
	}
}
