using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Adapter
{
	class MasrafGoster : ITarif
	{
		public String yazdir(String yemekAd)
		{
			YemekListesi yemekListesi = new YemekListesi();
			Yemek yemek = yemekListesi.yemekBul(yemekAd);
			return yemek.MasrafYazdir();
		}
	}
}
