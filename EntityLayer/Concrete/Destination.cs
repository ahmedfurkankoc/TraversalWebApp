﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Destination
	{
		[Key]
		public int DestinationId { get; set; }
        public string City { get; set; } = null!;
		public string DayNight { get; set; } = null!;
		public double Price { get; set; }
        public string Image { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Capacity { get; set; } 
        public bool Status { get; set; }
        public string CoverImage { get; set; } = null!;
        public string Details1 { get; set; } = null!;
        public string? Details2 { get; set; }
        public string? Image2 { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Reservation>? Reservations { get; set; }
        public int GuideId { get; set; }
        public Guide Guide { get; set; }
    }
}
