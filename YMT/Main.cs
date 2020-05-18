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
			ProxyForm proxyForm = new ProxyForm();
			this.Hide();
			proxyForm.ShowDialog();
			this.Show();
		}

		private void btnPrototype_Click(object sender, EventArgs e)
		{
			PrototypeForm prototypeForm = new PrototypeForm();
			this.Hide();
			prototypeForm.ShowDialog();
			this.Show();
		}

		private void btnFactory_Click(object sender, EventArgs e)
		{
			FactoryForm factoryForm = new FactoryForm();
			this.Hide();
			factoryForm.ShowDialog();
			this.Show();
		}

		private void btnFacade_Click(object sender, EventArgs e)
		{
			FacadeForm facadeForm = new FacadeForm();
			this.Hide();
			facadeForm.ShowDialog();
			this.Show();
		}

		private void btnBuilder_Click(object sender, EventArgs e)
		{
			BuilderForm builderForm = new BuilderForm();
			this.Hide();
			builderForm.ShowDialog();
			this.Show();
		}

		private void btnBridge_Click(object sender, EventArgs e)
		{
			BridgeForm bridgeForm = new BridgeForm();
			this.Hide();
			bridgeForm.ShowDialog();
			this.Show();
		}

		private void btnAdapter_Click(object sender, EventArgs e)
		{
			AdapterForm adapterForm = new AdapterForm();
			this.Hide();
			adapterForm.ShowDialog();
			this.Show();
		}

		private void btnAbstractFactory_Click(object sender, EventArgs e)
		{
			AbstractFactoryForm abstractFactoryForm = new AbstractFactoryForm();
			this.Hide();
			abstractFactoryForm.ShowDialog();
			this.Show();
		}
	}
}
