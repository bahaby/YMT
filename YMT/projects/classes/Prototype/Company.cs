using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Prototype
{
	public abstract class Company
	{
		public String Name { get; set; }
		public int AvailableJobsQuantity { get; set; }
		public int CompletedJobsQuantity { get; set; }
		public int Day { get; set; }

		public Company()
		{
			AvailableJobsQuantity = 0;
			CompletedJobsQuantity = 0;
			Day = 1;
		}

		public abstract Company Clone();
	}
}
