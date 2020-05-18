using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Adapter
{
	class YemekListesi
	{
		public List<Yemek> Yemekler = new List<Yemek> {
			new Yemek(
				"Menemen",
				new List<Malzeme> {
					new Malzeme("Domates", 3, 0.7),
					new Malzeme("Biber", 3, 0.5),
					new Malzeme("Yumurta", 4, 0.8),
				}
			),
			new Yemek(
				"Sucuklu Yumurta",
				new List<Malzeme>
				{
					new Malzeme("Sucuk", 1, 15),
					new Malzeme("Yumurta", 3, 0.8)
				}
			),
			new Yemek(
				"Peynirli Yumurta",
				new List<Malzeme>
				{
					new Malzeme("Peynir", 1, 8),
					new Malzeme("Yumurta", 3, 0.8)
				}
			),
		};

		public Yemek yemekBul(String yemekAd)
		{
			foreach (var yemek in Yemekler)
			{
				if (yemek.Ad == yemekAd)
				{
					return yemek;
				}
			}
			return null;
		}
	}
}
