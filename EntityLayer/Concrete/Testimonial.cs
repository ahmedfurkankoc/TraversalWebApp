using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Testimonial
	{
        [Key]
        public int TestimonialId { get; set; }
        public string Client { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string ClientImage { get; set; } = null!;
        public bool Status { get; set; }
    }
}
