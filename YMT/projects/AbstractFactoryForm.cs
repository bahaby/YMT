using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.AbstractFactory;
using YMT.projects.classes.AbstractFactory.Factories;

namespace YMT.projects
{
	public partial class AbstractFactoryForm : Form
	{
		public AbstractFactoryForm()
		{
			InitializeComponent();
		}

		private void AbstractFactoryForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Client entrepreneur = new Client(new ElegantClothesFactory());
			richTextBox1.Text = $"İş Adamı: {entrepreneur.DecribeYourClothes()}";

			Client student = new Client(new CasualClothesFactory());
			richTextBox1.Text = $"Öğrenci: {student.DecribeYourClothes()}";
		}
	}
}
