using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMT.projects.classes.Prototype
{
	class CompanyHistory
	{
		public List<Company> History = new List<Company>();
	
		public void addHistory(Company company)
		{
			this.History.Add(company.Clone());
			company.Day++;
		}
	}
}
