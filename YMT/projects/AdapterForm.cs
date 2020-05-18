using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Adapter;

namespace YMT.projects
{
	public partial class AdapterForm : Form
	{
		public AdapterForm()
		{
			InitializeComponent();
			foreach (var yemek in new YemekListesi().Yemekler)
			{
				listYemek.Items.Add(yemek.Ad);
			}
			listYemek.SelectedIndex = 0;
		}


		private void btnTarif_Click(object sender, EventArgs e)
		{
			TarifGoster tarifGoster = new TarifGoster();
			MessageBox.Show(
				tarifGoster.yazdir(listYemek.SelectedItem.ToString())	
			);
			
		}

		private void btnMasraf_Click(object sender, EventArgs e)
		{
			MasrafGoster masrafGoster = new MasrafGoster();
			MessageBox.Show(
				masrafGoster.yazdir(listYemek.SelectedItem.ToString())
			);
		}
	}
}
