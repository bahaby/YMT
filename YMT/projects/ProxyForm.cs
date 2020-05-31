using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Proxy;

namespace YMT.projects
{
	public partial class ProxyForm : Form
	{
		public ProxyForm()
		{
			InitializeComponent();
		}

        private void ProxyForm_Load(object sender, EventArgs e)
        {
        }
        
        Image image=Properties.Resources.OrnekResim;
        
        private void button2_Click(object sender, EventArgs e)
        {
            IGorsel resim2 = new Proxy();
            resim2.Goster(PictureBox,image);
            

        }
    }
}
