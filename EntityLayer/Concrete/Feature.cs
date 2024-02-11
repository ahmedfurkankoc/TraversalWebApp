using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Feature
	{
		[Key]
		public int FeatureId { get; set; }
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string Image { get; set; } = null!;
		public bool Status { get; set; }
    }
}
