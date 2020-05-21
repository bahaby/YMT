using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Prototype;

namespace YMT.projects
{
	public partial class PrototypeForm : Form
	{
		private List<Company> companies = new List<Company> {
			new Beko(),
			new Arcelik(),
			new Monster()
		};

		private List<CompanyHistory> companyHistories = new List<CompanyHistory>
		{
			new CompanyHistory(),
			new CompanyHistory(),
			new CompanyHistory()
		};

		public PrototypeForm()
		{
			InitializeComponent();
			foreach (var company in companies)
			{
				listCompany.Items.Add(company.Name);
			}
			listCompany.SelectedIndex = 0;
		}


		private void ReloadPage(int index)
		{
			lblAvQuantity.Text = companies[index].AvailableJobsQuantity.ToString();
			lblComQuantity.Text = companies[index].CompletedJobsQuantity.ToString();
			listHistory.Items.Clear();
			if (companyHistories[index].History != null) { 
				foreach (var company in companyHistories[index].History)
				{
					listHistory.Items.Add("Day: " + company.Day.ToString()
										+ " Available Jobs: " + company.AvailableJobsQuantity.ToString()
										+ " Completed Jobs: " + company.CompletedJobsQuantity.ToString());
				}
			}
		}

		private void btnAvPlus_Click(object sender, EventArgs e)
		{
			companies[listCompany.SelectedIndex].AvailableJobsQuantity++;
			lblAvQuantity.Text = companies[listCompany.SelectedIndex].AvailableJobsQuantity.ToString();
		}

		private void btnAvMinus_Click(object sender, EventArgs e)
		{
			companies[listCompany.SelectedIndex].AvailableJobsQuantity--;
			lblAvQuantity.Text = companies[listCompany.SelectedIndex].AvailableJobsQuantity.ToString();
		}

		private void btnComPlus_Click(object sender, EventArgs e)
		{
			companies[listCompany.SelectedIndex].CompletedJobsQuantity++;
			lblComQuantity.Text = companies[listCompany.SelectedIndex].CompletedJobsQuantity.ToString();
		}

		private void btnComMinus_Click(object sender, EventArgs e)
		{
			companies[listCompany.SelectedIndex].CompletedJobsQuantity--;
			lblComQuantity.Text = companies[listCompany.SelectedIndex].CompletedJobsQuantity.ToString();
		}

		private void listCompany_SelectedIndexChanged(object sender, EventArgs e)
		{
			ReloadPage(listCompany.SelectedIndex);
		}

		private void btnNextDay_Click(object sender, EventArgs e)
		{
			companyHistories[listCompany.SelectedIndex].addHistory(companies[listCompany.SelectedIndex]);
			ReloadPage(listCompany.SelectedIndex);
		}
	}
}
