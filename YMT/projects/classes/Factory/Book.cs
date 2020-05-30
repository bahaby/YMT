using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class Book: IProduct
	{
		private int _quantity = 1;
		public void AddQuantity()
		{
			this._quantity += 1;
		}
		public int Quantity()
		{
			return _quantity;
		}
		public String ProductName()
		{
			return "Book";
		}
	}
}
