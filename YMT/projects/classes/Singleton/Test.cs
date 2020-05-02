using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Singleton
{
	class Test
	{
		private String _deneme;
		public Test(String deneme)
		{
			_deneme = deneme;
		}
		public void ShowText()
		{
			MessageBox.Show(_deneme);
		}
	}
}
