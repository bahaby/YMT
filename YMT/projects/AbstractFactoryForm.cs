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

        private void button1_Click(object sender, EventArgs e)
        {
            Client girisimci = new Client(new ElegantClothesFactory());
            girisimci.DecribeYourClothes();
            richTextBox1.Text = $"Girişimci: {girisimci.DecribeYourClothes()}";

            Client ogrenci = new Client(new CasualClothesFactory());
            ogrenci.DecribeYourClothes();
            richTextBox1.Text = $"Girişimci: {ogrenci.DecribeYourClothes()}";
        }
    }
}
