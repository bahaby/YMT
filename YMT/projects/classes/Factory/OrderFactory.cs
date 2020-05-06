using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class OrderFactory
	{
		public IOrder CreateOrder(int index)
		{
			switch (index)
			{
				case 0:
					return new Buy();
				case 1:
					return new Rent();
				default:
					return null;
			}
		}
	}
}
