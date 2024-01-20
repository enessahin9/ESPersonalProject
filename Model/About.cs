using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class About : BaseModel
    {
        public string Profile { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

    }
}
