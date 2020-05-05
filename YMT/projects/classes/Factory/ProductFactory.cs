using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class ProductFactory
	{
		public IProduct CreateProduct(String product)
		{
			switch (product)
			{
				case "Book":
					return new Book();
				case "Pencil":
					return new Pencil();
				case "Notebook":
					return new Notebook();
				default:
					return null;
			}
		}
	}
}
