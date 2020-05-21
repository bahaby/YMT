using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Prototype
{
	class Arcelik : Company
	{
		public Arcelik()
		{
			Name = "Arçelik";
		}
		public override Company Clone()
		{
			return (Arcelik)MemberwiseClone();
		}
	}
}
