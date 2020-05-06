using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class Rent:IOrder
	{
		public bool Order()
		{
			return true;
		}
		public String Feedback()
		{
			return "There is no problem with Renting.";
		}
	}
}
