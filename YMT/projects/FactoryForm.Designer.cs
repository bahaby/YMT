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
			this.richTxtOrder = new System.Windows.Forms.RichTextBox();
			this.btnBook = new System.Windows.Forms.Button();
			this.btnNotebook = new System.Windows.Forms.Button();
			this.btnPencil = new System.Windows.Forms.Button();
			this.cboxPayment = new System.Windows.Forms.ComboBox();
			this.cboxOrder = new System.Windows.Forms.ComboBox();
			this.lblPurchase = new System.Windows.Forms.Label();
			this.lblOrder = new System.Windows.Forms.Label();
			this.btnOrder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTxtOrder
			// 
			this.richTxtOrder.Location = new System.Drawing.Point(86, 98);
			this.richTxtOrder.Name = "richTxtOrder";
			this.richTxtOrder.Size = new System.Drawing.Size(287, 266);
			this.richTxtOrder.TabIndex = 0;
			this.richTxtOrder.Text = "";
			// 
			// btnBook
			// 
			this.btnBook.Location = new System.Drawing.Point(411, 96);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(75, 23);
			this.btnBook.TabIndex = 1;
			this.btnBook.Text = "Book";
			this.btnBook.UseVisualStyleBackColor = true;
			this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
			// 
			// btnNotebook
			// 
			this.btnNotebook.Location = new System.Drawing.Point(411, 125);
			this.btnNotebook.Name = "btnNotebook";
			this.btnNotebook.Size = new System.Drawing.Size(75, 23);
			this.btnNotebook.TabIndex = 1;
			this.btnNotebook.Text = "Notebook";
			this.btnNotebook.UseVisualStyleBackColor = true;
			this.btnNotebook.Click += new System.EventHandler(this.btnNotebook_Click);
			// 
			// btnPencil
			// 
			this.btnPencil.Location = new System.Drawing.Point(411, 154);
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
			this.cboxPayment.Location = new System.Drawing.Point(196, 387);
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
			this.cboxOrder.Location = new System.Drawing.Point(196, 414);
			this.cboxOrder.Name = "cboxOrder";
			this.cboxOrder.Size = new System.Drawing.Size(121, 21);
			this.cboxOrder.TabIndex = 2;
			// 
			// lblPurchase
			// 
			this.lblPurchase.AutoSize = true;
			this.lblPurchase.Location = new System.Drawing.Point(86, 390);
			this.lblPurchase.Name = "lblPurchase";
			this.lblPurchase.Size = new System.Drawing.Size(48, 13);
			this.lblPurchase.TabIndex = 3;
			this.lblPurchase.Text = "Payment";
			// 
			// lblOrder
			// 
			this.lblOrder.AutoSize = true;
			this.lblOrder.Location = new System.Drawing.Point(86, 417);
			this.lblOrder.Name = "lblOrder";
			this.lblOrder.Size = new System.Drawing.Size(33, 13);
			this.lblOrder.TabIndex = 3;
			this.lblOrder.Text = "Order";
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(196, 460);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(75, 23);
			this.btnOrder.TabIndex = 4;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// FactoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 533);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.lblOrder);
			this.Controls.Add(this.lblPurchase);
			this.Controls.Add(this.cboxOrder);
			this.Controls.Add(this.cboxPayment);
			this.Controls.Add(this.btnPencil);
			this.Controls.Add(this.btnNotebook);
			this.Controls.Add(this.btnBook);
			this.Controls.Add(this.richTxtOrder);
			this.Name = "FactoryForm";
			this.Text = "FactoryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTxtOrder;
		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Button btnNotebook;
		private System.Windows.Forms.Button btnPencil;
		private System.Windows.Forms.ComboBox cboxPayment;
		private System.Windows.Forms.ComboBox cboxOrder;
		private System.Windows.Forms.Label lblPurchase;
		private System.Windows.Forms.Label lblOrder;
		private System.Windows.Forms.Button btnOrder;
	}
}