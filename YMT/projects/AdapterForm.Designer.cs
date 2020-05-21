namespace YMT.projects
{
	partial class AdapterForm
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
			this.listYemek = new System.Windows.Forms.ListBox();
			this.btnTarif = new System.Windows.Forms.Button();
			this.btnMasraf = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listYemek
			// 
			this.listYemek.FormattingEnabled = true;
			this.listYemek.Location = new System.Drawing.Point(102, 54);
			this.listYemek.Name = "listYemek";
			this.listYemek.Size = new System.Drawing.Size(120, 95);
			this.listYemek.TabIndex = 0;
			// 
			// btnTarif
			// 
			this.btnTarif.Location = new System.Drawing.Point(287, 69);
			this.btnTarif.Name = "btnTarif";
			this.btnTarif.Size = new System.Drawing.Size(87, 23);
			this.btnTarif.TabIndex = 1;
			this.btnTarif.Text = "Tarif Göster";
			this.btnTarif.UseVisualStyleBackColor = true;
			this.btnTarif.Click += new System.EventHandler(this.btnTarif_Click);
			// 
			// btnMasraf
			// 
			this.btnMasraf.Location = new System.Drawing.Point(287, 99);
			this.btnMasraf.Name = "btnMasraf";
			this.btnMasraf.Size = new System.Drawing.Size(87, 23);
			this.btnMasraf.TabIndex = 2;
			this.btnMasraf.Text = "Masraf Göster";
			this.btnMasraf.UseVisualStyleBackColor = true;
			this.btnMasraf.Click += new System.EventHandler(this.btnMasraf_Click);
			// 
			// AdapterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 213);
			this.Controls.Add(this.btnMasraf);
			this.Controls.Add(this.btnTarif);
			this.Controls.Add(this.listYemek);
			this.Name = "AdapterForm";
			this.Text = "AdapterForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listYemek;
		private System.Windows.Forms.Button btnTarif;
		private System.Windows.Forms.Button btnMasraf;
	}
}