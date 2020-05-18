namespace YMT
{
	partial class Main
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
			this.btnAdapter = new System.Windows.Forms.Button();
			this.btnBridge = new System.Windows.Forms.Button();
			this.btnBuilder = new System.Windows.Forms.Button();
			this.btnFacade = new System.Windows.Forms.Button();
			this.btnFactory = new System.Windows.Forms.Button();
			this.btnPrototype = new System.Windows.Forms.Button();
			this.btnProxy = new System.Windows.Forms.Button();
			this.btnSingleton = new System.Windows.Forms.Button();
			this.btnAbstractFactory = new System.Windows.Forms.Button();
			this.grpOnur = new System.Windows.Forms.GroupBox();
			this.grpHakan = new System.Windows.Forms.GroupBox();
			this.grpHasan = new System.Windows.Forms.GroupBox();
			this.grpBaha = new System.Windows.Forms.GroupBox();
			this.grpOnur.SuspendLayout();
			this.grpHakan.SuspendLayout();
			this.grpHasan.SuspendLayout();
			this.grpBaha.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdapter
			// 
			this.btnAdapter.Location = new System.Drawing.Point(31, 48);
			this.btnAdapter.Name = "btnAdapter";
			this.btnAdapter.Size = new System.Drawing.Size(274, 23);
			this.btnAdapter.TabIndex = 0;
			this.btnAdapter.Text = "Adapter";
			this.btnAdapter.UseVisualStyleBackColor = true;
			this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
			// 
			// btnBridge
			// 
			this.btnBridge.Location = new System.Drawing.Point(31, 48);
			this.btnBridge.Name = "btnBridge";
			this.btnBridge.Size = new System.Drawing.Size(274, 23);
			this.btnBridge.TabIndex = 0;
			this.btnBridge.Text = "Bridge";
			this.btnBridge.UseVisualStyleBackColor = true;
			this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
			// 
			// btnBuilder
			// 
			this.btnBuilder.Location = new System.Drawing.Point(31, 52);
			this.btnBuilder.Name = "btnBuilder";
			this.btnBuilder.Size = new System.Drawing.Size(274, 23);
			this.btnBuilder.TabIndex = 0;
			this.btnBuilder.Text = "Builder";
			this.btnBuilder.UseVisualStyleBackColor = true;
			this.btnBuilder.Click += new System.EventHandler(this.btnBuilder_Click);
			// 
			// btnFacade
			// 
			this.btnFacade.Location = new System.Drawing.Point(31, 19);
			this.btnFacade.Name = "btnFacade";
			this.btnFacade.Size = new System.Drawing.Size(274, 23);
			this.btnFacade.TabIndex = 0;
			this.btnFacade.Text = "Facade";
			this.btnFacade.UseVisualStyleBackColor = true;
			this.btnFacade.Click += new System.EventHandler(this.btnFacade_Click);
			// 
			// btnFactory
			// 
			this.btnFactory.Location = new System.Drawing.Point(31, 19);
			this.btnFactory.Name = "btnFactory";
			this.btnFactory.Size = new System.Drawing.Size(274, 23);
			this.btnFactory.TabIndex = 0;
			this.btnFactory.Text = "Factory";
			this.btnFactory.UseVisualStyleBackColor = true;
			this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
			// 
			// btnPrototype
			// 
			this.btnPrototype.Location = new System.Drawing.Point(31, 77);
			this.btnPrototype.Name = "btnPrototype";
			this.btnPrototype.Size = new System.Drawing.Size(274, 23);
			this.btnPrototype.TabIndex = 0;
			this.btnPrototype.Text = "Prototype";
			this.btnPrototype.UseVisualStyleBackColor = true;
			this.btnPrototype.Click += new System.EventHandler(this.btnPrototype_Click);
			// 
			// btnProxy
			// 
			this.btnProxy.Location = new System.Drawing.Point(31, 48);
			this.btnProxy.Name = "btnProxy";
			this.btnProxy.Size = new System.Drawing.Size(274, 27);
			this.btnProxy.TabIndex = 0;
			this.btnProxy.Text = "Proxy";
			this.btnProxy.UseVisualStyleBackColor = true;
			this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
			// 
			// btnSingleton
			// 
			this.btnSingleton.Location = new System.Drawing.Point(31, 19);
			this.btnSingleton.Name = "btnSingleton";
			this.btnSingleton.Size = new System.Drawing.Size(274, 27);
			this.btnSingleton.TabIndex = 0;
			this.btnSingleton.Text = "Singleton";
			this.btnSingleton.UseVisualStyleBackColor = true;
			this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
			// 
			// btnAbstractFactory
			// 
			this.btnAbstractFactory.Location = new System.Drawing.Point(31, 19);
			this.btnAbstractFactory.Name = "btnAbstractFactory";
			this.btnAbstractFactory.Size = new System.Drawing.Size(274, 23);
			this.btnAbstractFactory.TabIndex = 0;
			this.btnAbstractFactory.Text = "Abstract Factory";
			this.btnAbstractFactory.UseVisualStyleBackColor = true;
			this.btnAbstractFactory.Click += new System.EventHandler(this.btnAbstractFactory_Click);
			// 
			// grpOnur
			// 
			this.grpOnur.Controls.Add(this.btnFacade);
			this.grpOnur.Controls.Add(this.btnProxy);
			this.grpOnur.Location = new System.Drawing.Point(12, 12);
			this.grpOnur.Name = "grpOnur";
			this.grpOnur.Size = new System.Drawing.Size(338, 88);
			this.grpOnur.TabIndex = 1;
			this.grpOnur.TabStop = false;
			this.grpOnur.Text = "Onur Göz";
			// 
			// grpHakan
			// 
			this.grpHakan.Controls.Add(this.btnAbstractFactory);
			this.grpHakan.Controls.Add(this.btnBridge);
			this.grpHakan.Location = new System.Drawing.Point(12, 106);
			this.grpHakan.Name = "grpHakan";
			this.grpHakan.Size = new System.Drawing.Size(338, 88);
			this.grpHakan.TabIndex = 1;
			this.grpHakan.TabStop = false;
			this.grpHakan.Text = "Hakan Sarı";
			// 
			// grpHasan
			// 
			this.grpHasan.Controls.Add(this.btnSingleton);
			this.grpHasan.Controls.Add(this.btnBuilder);
			this.grpHasan.Location = new System.Drawing.Point(12, 200);
			this.grpHasan.Name = "grpHasan";
			this.grpHasan.Size = new System.Drawing.Size(338, 88);
			this.grpHasan.TabIndex = 1;
			this.grpHasan.TabStop = false;
			this.grpHasan.Text = "Hasan Sofioğlu";
			// 
			// grpBaha
			// 
			this.grpBaha.Controls.Add(this.btnFactory);
			this.grpBaha.Controls.Add(this.btnAdapter);
			this.grpBaha.Controls.Add(this.btnPrototype);
			this.grpBaha.Location = new System.Drawing.Point(12, 294);
			this.grpBaha.Name = "grpBaha";
			this.grpBaha.Size = new System.Drawing.Size(338, 116);
			this.grpBaha.TabIndex = 1;
			this.grpBaha.TabStop = false;
			this.grpBaha.Text = "Bahadır Bayraktar";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 427);
			this.Controls.Add(this.grpBaha);
			this.Controls.Add(this.grpHasan);
			this.Controls.Add(this.grpHakan);
			this.Controls.Add(this.grpOnur);
			this.Name = "Main";
			this.Text = "Form1";
			this.grpOnur.ResumeLayout(false);
			this.grpHakan.ResumeLayout(false);
			this.grpHasan.ResumeLayout(false);
			this.grpBaha.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdapter;
		private System.Windows.Forms.Button btnBridge;
		private System.Windows.Forms.Button btnBuilder;
		private System.Windows.Forms.Button btnFacade;
		private System.Windows.Forms.Button btnFactory;
		private System.Windows.Forms.Button btnPrototype;
		private System.Windows.Forms.Button btnProxy;
		private System.Windows.Forms.Button btnSingleton;
		private System.Windows.Forms.Button btnAbstractFactory;
		private System.Windows.Forms.GroupBox grpOnur;
		private System.Windows.Forms.GroupBox grpHakan;
		private System.Windows.Forms.GroupBox grpHasan;
		private System.Windows.Forms.GroupBox grpBaha;
	}
}

