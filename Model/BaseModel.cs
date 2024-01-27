using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class BaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsDeleted { get; set; } = false;
		public bool IsActive { get; set; } = true;
		public DateTime DataCreated { get; set; } = DateTime.Now;
		public DateTime? DateModified { get; set; }
	}
}
