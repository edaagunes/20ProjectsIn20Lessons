namespace AdonetCustomerProject
{
	partial class FrmMap
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
			this.btnOpenCityForm = new System.Windows.Forms.Button();
			this.btnOpenCustomer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenCityForm
			// 
			this.btnOpenCityForm.Location = new System.Drawing.Point(42, 23);
			this.btnOpenCityForm.Name = "btnOpenCityForm";
			this.btnOpenCityForm.Size = new System.Drawing.Size(178, 60);
			this.btnOpenCityForm.TabIndex = 0;
			this.btnOpenCityForm.Text = "Şehir İşlemleri";
			this.btnOpenCityForm.UseVisualStyleBackColor = true;
			this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
			// 
			// btnOpenCustomer
			// 
			this.btnOpenCustomer.Location = new System.Drawing.Point(42, 105);
			this.btnOpenCustomer.Name = "btnOpenCustomer";
			this.btnOpenCustomer.Size = new System.Drawing.Size(178, 60);
			this.btnOpenCustomer.TabIndex = 1;
			this.btnOpenCustomer.Text = "Müşteri İşlemleri";
			this.btnOpenCustomer.UseVisualStyleBackColor = true;
			this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(42, 185);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(178, 60);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Çıkış Yap";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenCustomer);
			this.Controls.Add(this.btnOpenCityForm);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formlar";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCityForm;
		private System.Windows.Forms.Button btnOpenCustomer;
		private System.Windows.Forms.Button btnExit;
	}
}