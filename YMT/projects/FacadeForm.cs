using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Facade;

namespace YMT.projects
{
	public partial class FacadeForm : Form
	{
		public FacadeForm()
		{
			InitializeComponent();
		}
		//[[5, 10], [10, 16]]
		List<List<int>> sayilar = new List<List<int>>
		{
			new List<int>{5, 10},
			new List<int>{10, 16},
		};

		public List<dynamic> Hopa(List<List<int>> sundura)
		{
			//code
			return null;
			//return
			/*
			[41], // ((5 + 10) + (10, 16))
			[76], // ((5 * 10) + (10 + 16))
			[24], // ((5 * 10) - (10 + 16))
			....
			...
			..
			.
			*/
			 
		}
	}
}
