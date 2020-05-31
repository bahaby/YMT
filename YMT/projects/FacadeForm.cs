
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
        private void FacadeForm_Load(object sender, EventArgs e)
        {
			
		}
		string Ad;
		string Tc;
		string MusteriNo;
		int Talep;
		private void KrediCekbtn_Click(object sender, EventArgs e)
        {
			Ad = Adtxt.Text; 
			Tc = Tctxt.Text;
			MusteriNo = MusteriNotxt.Text;
			Talep = Convert.ToInt32(CekilecekMiktartxt.Text);

			Facade facade = new Facade(); 
			Tutarlbl.Text = facade.KrediKullan(new Musteri { Ad = Ad, TcNo = Tc, MusteriNumarasi = MusteriNo }, Talep + " TL");
		}
        private void CekilecekMiktartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);// keypres eventi ile sadece sayı girişi sağlandı
		}
    }
}
