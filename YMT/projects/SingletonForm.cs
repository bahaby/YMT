using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Singleton;

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
			List<Tuple<String, String>> liste = new List<Tuple<string, string>>();
			List<Tuple<int, String>> adaylar = new List<Tuple<int, String>>{
				new Tuple<int, string>( 2, "Onur"),
				new Tuple<int, string>( 2, "Hakan"),
				new Tuple<int, string>( 2, "Hasan"),
				new Tuple<int, string>( 3, "Bahadır"),
			};
			List<String> gorevler = new List<String> {
				"AbstractFactory",
				"Adapter",
				"Bridge",
				"Builder",
				"Facade",
				"Factory",
				"Prototype",
				"Proxy",
				"Singleton",
			};
			foreach (var aday in adaylar)
			{
				for (int i = 0; i < aday.Item1; i++)
				{
					gorevler = gorevler.OrderBy(a => Guid.NewGuid()).ToList();
					liste.Add(new Tuple<string, string>(aday.Item2, gorevler[0])); ;
					gorevler.RemoveAt(0);
				}
			}

			richTextBox1.Clear();
			foreach (var item in liste)
			{
				richTextBox1.AppendText(item.Item1 + " - " + item.Item2 + "\n");
			}
		}
	}
}
