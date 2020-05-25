
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
		private int talep;
        

        private void FacadeForm_Load(object sender, EventArgs e)
        {
		
		}

        private void KrediCekbtn_Click(object sender, EventArgs e)
        {
			ad = Adtxt.Text; // textBox'dan veriler alınıyor.
			tc = Tctxt.Text;
			musterino = MusteriNotxt.Text;
			talep = Convert.ToInt32(CekilecekMiktartxt.Text);

			Facade fcd = new Facade(); // Facade sınıfından fcd nesenesini üretiyoruz
			Tutarlbl.Text = fcd.KrediKullan( // müşteri bilgilerini iletiyoruz.
			new Musteri { Ad = ad, TcNo = tc, MusteriNumarasi = musterino }, talep + " TL");
		}

        private void CekilecekMiktartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);// keypres eventi ile sadece sayı girişi sağlandı
		}
    }
}
