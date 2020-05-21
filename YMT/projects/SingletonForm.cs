using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YMT.projects
{
    public partial class SingletonForm : Form
    {
        public SingletonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassSingleton singleton = ClassSingleton.boxName();
            MessageBox.Show(singleton.box(tBxBoxCode.Text));
        }
    }
}
