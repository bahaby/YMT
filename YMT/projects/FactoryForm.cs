using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMT.projects.classes.Factory;

namespace YMT.projects
{
	public partial class FactoryForm : Form
	{

		ProductFactory productFactory = new ProductFactory();
		List<IProduct> order = new List<IProduct>();

		public FactoryForm()
		{
			InitializeComponent();
			cboxOrder.SelectedIndex = 0;
			cboxPayment.SelectedIndex = 0;
		}

		private void btnBook_Click(object sender, EventArgs e)
		{
			this.AddOrder(productFactory.CreateProduct("Book"));
			this.refresh();
		}

		private void btnNotebook_Click(object sender, EventArgs e)
		{
			this.AddOrder(productFactory.CreateProduct("Notebook"));
			this.refresh();
		}

		private void btnPencil_Click(object sender, EventArgs e)
		{
			this.AddOrder(productFactory.CreateProduct("Pencil"));
			this.refresh();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			OrderFactory orderFactory = new OrderFactory();
			PaymentFactory paymentFactory = new PaymentFactory();
			IPayment paymentData = paymentFactory.CreatePayment(cboxPayment.SelectedIndex);
			IOrder orderData = orderFactory.CreateOrder(cboxOrder.SelectedIndex);

			String message = "";
			foreach (var orderItem in order)
			{
				message += orderItem.ProductName() + "\t\t" + orderItem.Quantity().ToString() + "\n";
			}
			message += paymentData.Feedback() + "\n";
			message += orderData.Feedback() + "\n";

			MessageBox.Show(message);

			order.Clear();
			message = "";
			refresh();
			cboxOrder.SelectedIndex = 0;
			cboxPayment.SelectedIndex = 0;

		}

		private void refresh()
		{
			richTxtOrder.Clear();
			foreach (var orderItem in order)
			{
				richTxtOrder.AppendText(orderItem.ProductName() + "\t\t" + orderItem.Quantity().ToString() + "\n");
			}
		}
		private void AddOrder(IProduct orderItem)
		{
			bool isContains = false;
			int index = 0;
			foreach (var item in order)
			{
				if (item.ProductName() == orderItem.ProductName())
				{
					isContains = true;
					order[index].AddQuantity();
					break;
				}
				index++;
			}
			if (!isContains)
			{
				order.Add(orderItem);
			}
		}

	}
}
