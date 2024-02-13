using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public string PersonCount { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = null!;
        public int DestinationId { get; set; }
        public Destination? Destination { get; set; }
    }
}

