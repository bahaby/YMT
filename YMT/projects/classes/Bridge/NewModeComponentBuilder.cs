using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Bridge
{
	public class NewModeComponentBuilder : ComponentImplementor
	{
		public override void ComponentBuilder()
		{
			MessageBox.Show("Component'ler Tüm Efectler ile Birlikle Oluşturuldu.");
		}
	}

}
