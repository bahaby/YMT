
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Facade;

namespace YMT.projects
{
	public partial class FacadeForm : Form
	{
		public FacadeForm()
		{
			InitializeComponent();
		}

		private string ad; // Çektiğimiz verileri tutacak değişkenleri tanımlıyoruz
		private string tc;
		private string musterino;
		private string talep;
        

        private void FacadeForm_Load(object sender, EventArgs e)
        {
		
		}

        private void KrediCekbtn_Click(object sender, EventArgs e)
        {
			ad = Adtxt.Text; // textBox'dan verileri çekiyoruz
			tc = Tctxt.Text;
			musterino = MusteriNotxt.Text;
			talep = CekilecekMiktartxt.Text;

			Facade fcd = new Facade(); // Facade sınıfından nesnemizi gerçekliyoruz
			Tutarlbl.Text = fcd.KrediKullan( // Musteri bilgilerini yolluyoruz 
			new Musteri { Ad = ad, TcNo = tc, MusteriNumarasi = musterino }, talep + " TL");
		}
    }
}
