using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class PaymentFactory
	{
		public IPayment CreatePayment(int index)
		{
			switch (index)
			{
				case 0:
					return new CreditCard();
				case 1:
					return new Cash();
				default:
					return null;
			}
		}
	}
}
