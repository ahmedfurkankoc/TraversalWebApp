using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int AboutId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
		public string Image1 { get; set; } = null!;
		public string Title2 { get; set; } = null!;
        public string Description2 { get; set; } = null!;
		public bool Status { get; set; }
    }
}
