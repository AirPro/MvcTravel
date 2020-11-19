using System;
using System.Collections.Generic;

namespace Models.DomainModels
{
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public string VenueContactInfo { get; set; }
    }
}
