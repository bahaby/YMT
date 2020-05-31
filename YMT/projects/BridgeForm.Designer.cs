namespace YMT.projects
{
	partial class BridgeForm
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
			this.btnOld = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOld
			// 
			this.btnOld.Location = new System.Drawing.Point(330, 122);
			this.btnOld.Name = "btnOld";
			this.btnOld.Size = new System.Drawing.Size(75, 23);
			this.btnOld.TabIndex = 0;
			this.btnOld.Text = "Old";
			this.btnOld.UseVisualStyleBackColor = true;
			this.btnOld.Click += new System.EventHandler(this.btnOld_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(330, 162);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// BridgeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 366);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnOld);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BridgeForm";
			this.Text = "BridgeForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOld;
		private System.Windows.Forms.Button btnNew;
	}
}