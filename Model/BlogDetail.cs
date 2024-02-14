using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class BlogDetail:BaseModel
	{
		public string Description { get; set; }
        public string? Description2 { get; set; }
		public string? Description3 { get; set;}
        public string ImageUrl { get; set; }
        public string? ImageUrl2 { get; set; }

		public string? ImageUrl3 { get; set;}
        public string? Tags { get; set; }
		public ICollection<BlogCategory> BlogCategories { get; set; }
	}
}
