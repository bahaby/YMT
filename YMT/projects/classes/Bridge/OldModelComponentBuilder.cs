using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Bridge
{
	public class OldModelComponentBuilder : ComponentImplementor
	{
		public override void ComponentBuilder()
		{
			MessageBox.Show("Component'ler Efekt Olmadan Çalıştırıldı");
		}
	}
}
