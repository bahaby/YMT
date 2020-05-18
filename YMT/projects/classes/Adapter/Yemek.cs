using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Adapter
{
	class Yemek
	{
		public String Ad { get; private set; }
		public List<Malzeme> Malzemeler { get; private set; }

		public Yemek(String ad, List<Malzeme> malzemeler)
		{
			this.Ad = ad;
			this.Malzemeler = malzemeler;
		}

		public String MasrafYazdir()
		{

			String message = this.Ad + " Fiyat Listesi \n";

			foreach (var malzeme in this.Malzemeler)
			{
				message += malzeme.Ad + ": " + malzeme.Adet.ToString() + " x " + malzeme.Price.ToString() + " TL = " + (malzeme.Price * malzeme.Adet).ToString() + " TL \n";
			}

			return message;
		}

		public String TarifYazdir()
		{

			String message = this.Ad + " Tarifi \n";

			foreach (var malzeme in this.Malzemeler)
			{
				message += malzeme.Adet.ToString() + " x " + malzeme.Ad + "\n";
			}

			return message;
		}
	}
}
