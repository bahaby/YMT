using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Adapter
{
	class Malzeme
	{
		public String Ad { get; private set; }
		public int Adet { get; private set; }
		public double Price { get; private set; }

		public Malzeme(String ad, int adet, double price)
		{
			this.Ad = ad;
			this.Adet = adet;
			this.Price = price;
		}
	}
}
