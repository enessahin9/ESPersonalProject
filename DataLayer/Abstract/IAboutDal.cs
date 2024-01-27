using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// About icin ekstra bir ozellik tanimlanacaksa IGeneric icerisine degil, IAboutDal.cs icerisine yazilacak.

namespace DataLayer.Abstract
{
	public interface IAboutDal : IGenericDal<About>
	{
	}
}
