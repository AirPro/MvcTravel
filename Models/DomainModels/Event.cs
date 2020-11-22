using System;
using System.Collections.Generic;

namespace MvcTravel.Models.DomainModels
{
    public partial class Event
    {
        public Event()
        {
            Promoter = new HashSet<Promoter>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventCity { get; set; }
        public DateTime EventDate { get; set; }

        public virtual ICollection<Promoter> Promoter { get; set; }
    }
}
