using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Prototype
{
	class Beko : Company
	{
		public Beko(){
			Name = "Beko";
		}
		public override Company Clone()
		{
			return (Beko)MemberwiseClone();
		}
	}
}
