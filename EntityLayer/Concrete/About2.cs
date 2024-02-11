using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About2
	{
		[Key]
		public int About2Id { get; set; }
        public string Title1 { get; set; } = null!;
        public string Title2 { get; set; } = null!;
        public string Desciption { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
