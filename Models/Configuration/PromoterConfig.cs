using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.Configuration
{
	internal class PromoterConfig : IEntityTypeConfiguration<Promoter>
	{
		public void Configure(EntityTypeBuilder<Promoter> entity)
		{
			entity.HasData(
				new Promoter { PromoterId = 1, PromoterName = "Promoter Name 1", PromoterAddress = "Promoter Address 1", PromoterContactInfo = "Promoter Contact Info 1"},
				new Promoter { PromoterId = 2, PromoterName = "Promoter Name 2", PromoterAddress = "Promoter Address 2", PromoterContactInfo = "Promoter Contact Info 2" }

			);
		}
	}
}
