using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Prototype
{
	class Monster : Company
	{
		public Monster()
		{
			Name = "Monster";
		}
		public override Company Clone()
		{
			return (Monster)MemberwiseClone(); 
		}
	}
}
