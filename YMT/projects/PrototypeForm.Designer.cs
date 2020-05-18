namespace YMT.projects
{
	partial class PrototypeForm
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
			this.listCompany = new System.Windows.Forms.ListBox();
			this.lblAvailable = new System.Windows.Forms.Label();
			this.lblCompleted = new System.Windows.Forms.Label();
			this.lblAvQuantity = new System.Windows.Forms.Label();
			this.lblComQuantity = new System.Windows.Forms.Label();
			this.btnAvPlus = new System.Windows.Forms.Button();
			this.btnAvMinus = new System.Windows.Forms.Button();
			this.btnComPlus = new System.Windows.Forms.Button();
			this.btnComMinus = new System.Windows.Forms.Button();
			this.btnNextDay = new System.Windows.Forms.Button();
			this.listHistory = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listCompany
			// 
			this.listCompany.FormattingEnabled = true;
			this.listCompany.Location = new System.Drawing.Point(52, 77);
			this.listCompany.Name = "listCompany";
			this.listCompany.Size = new System.Drawing.Size(120, 95);
			this.listCompany.TabIndex = 0;
			this.listCompany.SelectedIndexChanged += new System.EventHandler(this.listCompany_SelectedIndexChanged);
			// 
			// lblAvailable
			// 
			this.lblAvailable.AutoSize = true;
			this.lblAvailable.Location = new System.Drawing.Point(184, 86);
			this.lblAvailable.Name = "lblAvailable";
			this.lblAvailable.Size = new System.Drawing.Size(56, 13);
			this.lblAvailable.TabIndex = 1;
			this.lblAvailable.Text = "Available: ";
			// 
			// lblCompleted
			// 
			this.lblCompleted.AutoSize = true;
			this.lblCompleted.Location = new System.Drawing.Point(184, 145);
			this.lblCompleted.Name = "lblCompleted";
			this.lblCompleted.Size = new System.Drawing.Size(63, 13);
			this.lblCompleted.TabIndex = 1;
			this.lblCompleted.Text = "Completed: ";
			// 
			// lblAvQuantity
			// 
			this.lblAvQuantity.AutoSize = true;
			this.lblAvQuantity.Location = new System.Drawing.Point(266, 86);
			this.lblAvQuantity.Name = "lblAvQuantity";
			this.lblAvQuantity.Size = new System.Drawing.Size(0, 13);
			this.lblAvQuantity.TabIndex = 2;
			// 
			// lblComQuantity
			// 
			this.lblComQuantity.AutoSize = true;
			this.lblComQuantity.Location = new System.Drawing.Point(266, 145);
			this.lblComQuantity.Name = "lblComQuantity";
			this.lblComQuantity.Size = new System.Drawing.Size(0, 13);
			this.lblComQuantity.TabIndex = 3;
			// 
			// btnAvPlus
			// 
			this.btnAvPlus.Location = new System.Drawing.Point(322, 81);
			this.btnAvPlus.Name = "btnAvPlus";
			this.btnAvPlus.Size = new System.Drawing.Size(22, 23);
			this.btnAvPlus.TabIndex = 4;
			this.btnAvPlus.Text = "+";
			this.btnAvPlus.UseVisualStyleBackColor = true;
			this.btnAvPlus.Click += new System.EventHandler(this.btnAvPlus_Click);
			// 
			// btnAvMinus
			// 
			this.btnAvMinus.Location = new System.Drawing.Point(350, 81);
			this.btnAvMinus.Name = "btnAvMinus";
			this.btnAvMinus.Size = new System.Drawing.Size(22, 23);
			this.btnAvMinus.TabIndex = 4;
			this.btnAvMinus.Text = "-";
			this.btnAvMinus.UseVisualStyleBackColor = true;
			this.btnAvMinus.Click += new System.EventHandler(this.btnAvMinus_Click);
			// 
			// btnComPlus
			// 
			this.btnComPlus.Location = new System.Drawing.Point(322, 140);
			this.btnComPlus.Name = "btnComPlus";
			this.btnComPlus.Size = new System.Drawing.Size(22, 23);
			this.btnComPlus.TabIndex = 4;
			this.btnComPlus.Text = "+";
			this.btnComPlus.UseVisualStyleBackColor = true;
			this.btnComPlus.Click += new System.EventHandler(this.btnComPlus_Click);
			// 
			// btnComMinus
			// 
			this.btnComMinus.Location = new System.Drawing.Point(350, 140);
			this.btnComMinus.Name = "btnComMinus";
			this.btnComMinus.Size = new System.Drawing.Size(22, 23);
			this.btnComMinus.TabIndex = 4;
			this.btnComMinus.Text = "-";
			this.btnComMinus.UseVisualStyleBackColor = true;
			this.btnComMinus.Click += new System.EventHandler(this.btnComMinus_Click);
			// 
			// btnNextDay
			// 
			this.btnNextDay.Location = new System.Drawing.Point(256, 237);
			this.btnNextDay.Name = "btnNextDay";
			this.btnNextDay.Size = new System.Drawing.Size(75, 23);
			this.btnNextDay.TabIndex = 5;
			this.btnNextDay.Text = "Next Day";
			this.btnNextDay.UseVisualStyleBackColor = true;
			this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
			// 
			// listHistory
			// 
			this.listHistory.FormattingEnabled = true;
			this.listHistory.Location = new System.Drawing.Point(429, 77);
			this.listHistory.Name = "listHistory";
			this.listHistory.Size = new System.Drawing.Size(226, 277);
			this.listHistory.TabIndex = 6;
			// 
			// PrototypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listHistory);
			this.Controls.Add(this.btnNextDay);
			this.Controls.Add(this.btnComMinus);
			this.Controls.Add(this.btnComPlus);
			this.Controls.Add(this.btnAvMinus);
			this.Controls.Add(this.btnAvPlus);
			this.Controls.Add(this.lblComQuantity);
			this.Controls.Add(this.lblAvQuantity);
			this.Controls.Add(this.lblCompleted);
			this.Controls.Add(this.lblAvailable);
			this.Controls.Add(this.listCompany);
			this.Name = "PrototypeForm";
			this.Text = "PrototypeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listCompany;
		private System.Windows.Forms.Label lblAvailable;
		private System.Windows.Forms.Label lblCompleted;
		private System.Windows.Forms.Label lblAvQuantity;
		private System.Windows.Forms.Label lblComQuantity;
		private System.Windows.Forms.Button btnAvPlus;
		private System.Windows.Forms.Button btnAvMinus;
		private System.Windows.Forms.Button btnComPlus;
		private System.Windows.Forms.Button btnComMinus;
		private System.Windows.Forms.Button btnNextDay;
		private System.Windows.Forms.ListBox listHistory;
	}
}