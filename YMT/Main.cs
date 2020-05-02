using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects;

namespace YMT
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnSingleton_Click(object sender, EventArgs e)
		{
			SingletonForm singletonForm = new SingletonForm();
			this.Hide();
			singletonForm.ShowDialog();
			this.Show();
		}

		private void btnProxy_Click(object sender, EventArgs e)
		{

		}

		private void btnPrototype_Click(object sender, EventArgs e)
		{

		}

		private void btnFactory_Click(object sender, EventArgs e)
		{

		}

		private void btnFacade_Click(object sender, EventArgs e)
		{

		}

		private void btnBuilder_Click(object sender, EventArgs e)
		{

		}

		private void btnBridge_Click(object sender, EventArgs e)
		{

		}

		private void btnAdapter_Click(object sender, EventArgs e)
		{

		}

		private void btnAbstractFactory_Click(object sender, EventArgs e)
		{

		}
	}
}
