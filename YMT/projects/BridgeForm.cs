using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Bridge;

namespace YMT.projects
{
	public partial class BridgeForm : Form
	{
		ComponentAbstraction compBuilder;
		public BridgeForm()
		{
			InitializeComponent();
			compBuilder = new RefinedComponentAbstraction();
		}

		private void btnOld_Click(object sender, EventArgs e)
		{
			compBuilder._componentBuilder = new OldModelComponentBuilder();
			compBuilder.ComponentBuilder();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			compBuilder._componentBuilder = new NewModeComponentBuilder();
			compBuilder.ComponentBuilder();
		}
	}
}
