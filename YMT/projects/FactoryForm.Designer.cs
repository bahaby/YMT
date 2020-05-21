namespace YMT.projects
{
	partial class FactoryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBook = new System.Windows.Forms.Button();
			this.btnNotebook = new System.Windows.Forms.Button();
			this.btnPencil = new System.Windows.Forms.Button();
			this.cboxPayment = new System.Windows.Forms.ComboBox();
			this.cboxOrder = new System.Windows.Forms.ComboBox();
			this.lblPurchase = new System.Windows.Forms.Label();
			this.lblOrder = new System.Windows.Forms.Label();
			this.btnOrder = new System.Windows.Forms.Button();
			this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listOrder = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// btnBook
			// 
			this.btnBook.Location = new System.Drawing.Point(232, 12);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(75, 23);
			this.btnBook.TabIndex = 1;
			this.btnBook.Text = "Book";
			this.btnBook.UseVisualStyleBackColor = true;
			this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
			// 
			// btnNotebook
			// 
			this.btnNotebook.Location = new System.Drawing.Point(232, 41);
			this.btnNotebook.Name = "btnNotebook";
			this.btnNotebook.Size = new System.Drawing.Size(75, 23);
			this.btnNotebook.TabIndex = 1;
			this.btnNotebook.Text = "Notebook";
			this.btnNotebook.UseVisualStyleBackColor = true;
			this.btnNotebook.Click += new System.EventHandler(this.btnNotebook_Click);
			// 
			// btnPencil
			// 
			this.btnPencil.Location = new System.Drawing.Point(232, 70);
			this.btnPencil.Name = "btnPencil";
			this.btnPencil.Size = new System.Drawing.Size(75, 23);
			this.btnPencil.TabIndex = 1;
			this.btnPencil.Text = "Pencil";
			this.btnPencil.UseVisualStyleBackColor = true;
			this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
			// 
			// cboxPayment
			// 
			this.cboxPayment.FormattingEnabled = true;
			this.cboxPayment.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
			this.cboxPayment.Location = new System.Drawing.Point(105, 298);
			this.cboxPayment.Name = "cboxPayment";
			this.cboxPayment.Size = new System.Drawing.Size(121, 21);
			this.cboxPayment.TabIndex = 2;
			// 
			// cboxOrder
			// 
			this.cboxOrder.FormattingEnabled = true;
			this.cboxOrder.Items.AddRange(new object[] {
            "Buy",
            "Rent"});
			this.cboxOrder.Location = new System.Drawing.Point(105, 330);
			this.cboxOrder.Name = "cboxOrder";
			this.cboxOrder.Size = new System.Drawing.Size(121, 21);
			this.cboxOrder.TabIndex = 2;
			// 
			// lblPurchase
			// 
			this.lblPurchase.AutoSize = true;
			this.lblPurchase.Location = new System.Drawing.Point(9, 306);
			this.lblPurchase.Name = "lblPurchase";
			this.lblPurchase.Size = new System.Drawing.Size(48, 13);
			this.lblPurchase.TabIndex = 3;
			this.lblPurchase.Text = "Payment";
			// 
			// lblOrder
			// 
			this.lblOrder.AutoSize = true;
			this.lblOrder.Location = new System.Drawing.Point(9, 333);
			this.lblOrder.Name = "lblOrder";
			this.lblOrder.Size = new System.Drawing.Size(33, 13);
			this.lblOrder.TabIndex = 3;
			this.lblOrder.Text = "Order";
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(119, 376);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(75, 23);
			this.btnOrder.TabIndex = 4;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// product
			// 
			this.product.Text = "Product";
			this.product.Width = 150;
			// 
			// quantity
			// 
			this.quantity.Text = "Quantity";
			// 
			// listOrder
			// 
			this.listOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.quantity});
			this.listOrder.HideSelection = false;
			this.listOrder.Location = new System.Drawing.Point(12, 12);
			this.listOrder.Name = "listOrder";
			this.listOrder.Size = new System.Drawing.Size(214, 259);
			this.listOrder.TabIndex = 5;
			this.listOrder.UseCompatibleStateImageBehavior = false;
			this.listOrder.View = System.Windows.Forms.View.Details;
			// 
			// FactoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 422);
			this.Controls.Add(this.listOrder);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.lblOrder);
			this.Controls.Add(this.lblPurchase);
			this.Controls.Add(this.cboxOrder);
			this.Controls.Add(this.cboxPayment);
			this.Controls.Add(this.btnPencil);
			this.Controls.Add(this.btnNotebook);
			this.Controls.Add(this.btnBook);
			this.Name = "FactoryForm";
			this.Text = "FactoryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Button btnNotebook;
		private System.Windows.Forms.Button btnPencil;
		private System.Windows.Forms.ComboBox cboxPayment;
		private System.Windows.Forms.ComboBox cboxOrder;
		private System.Windows.Forms.Label lblPurchase;
		private System.Windows.Forms.Label lblOrder;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.ColumnHeader product;
		private System.Windows.Forms.ColumnHeader quantity;
		private System.Windows.Forms.ListView listOrder;
	}
}