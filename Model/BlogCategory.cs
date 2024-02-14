using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class BlogCategory:BaseModel
{
    public ICollection<BlogDetail> BlogDetails { get; set; }
}
