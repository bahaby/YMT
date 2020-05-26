using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Builder; 

namespace YMT.projects
{
	public partial class BuilderForm : Form
	{
		public BuilderForm()
		{
			InitializeComponent();

		}
        private void button1_Click(object sender, EventArgs e)
        {
            BuilderClass builderClass = new KisilerConcreteBuilder();
            DirectorClass gonder = new DirectorClass();
            gonder.Gonder(builderClass);
            builderClass.Hediye.ToString();

            builderClass = new KazanankisiBuilder();
            gonder.Gonder(builderClass);
            builderClass.Hediye.ToString();




        }
    }
}
