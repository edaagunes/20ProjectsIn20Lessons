namespace GasPriceSimulation
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGasAmount = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtGasolinePrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDieselPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLpgPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rdbGasoline = new System.Windows.Forms.RadioButton();
			this.rdbDiesel = new System.Windows.Forms.RadioButton();
			this.rdbLpg = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(228, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gas Price Simulation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(68, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Yakıt Miktarı:";
			// 
			// txtGasAmount
			// 
			this.txtGasAmount.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.txtGasAmount.Location = new System.Drawing.Point(208, 186);
			this.txtGasAmount.Name = "txtGasAmount";
			this.txtGasAmount.Size = new System.Drawing.Size(301, 32);
			this.txtGasAmount.TabIndex = 2;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.txtTotalPrice.Location = new System.Drawing.Point(208, 228);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(301, 32);
			this.txtTotalPrice.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Toplam Tutar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(43, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 24);
			this.label4.TabIndex = 5;
			this.label4.Text = "Dolum Durumu:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(208, 270);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(300, 27);
			this.progressBar1.TabIndex = 6;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.btnStart.Location = new System.Drawing.Point(269, 329);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(156, 33);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "İşlemi Başlat";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLpgPrice);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDieselPrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtGasolinePrice);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(591, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 204);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fiyatlar";
			// 
			// txtGasolinePrice
			// 
			this.txtGasolinePrice.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.txtGasolinePrice.Location = new System.Drawing.Point(104, 28);
			this.txtGasolinePrice.Name = "txtGasolinePrice";
			this.txtGasolinePrice.ReadOnly = true;
			this.txtGasolinePrice.Size = new System.Drawing.Size(177, 32);
			this.txtGasolinePrice.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 24);
			this.label5.TabIndex = 3;
			this.label5.Text = "Benzin:";
			// 
			// txtDieselPrice
			// 
			this.txtDieselPrice.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.txtDieselPrice.Location = new System.Drawing.Point(104, 75);
			this.txtDieselPrice.Name = "txtDieselPrice";
			this.txtDieselPrice.ReadOnly = true;
			this.txtDieselPrice.Size = new System.Drawing.Size(177, 32);
			this.txtDieselPrice.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "Motorin:";
			// 
			// txtLpgPrice
			// 
			this.txtLpgPrice.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.txtLpgPrice.Location = new System.Drawing.Point(104, 122);
			this.txtLpgPrice.Name = "txtLpgPrice";
			this.txtLpgPrice.ReadOnly = true;
			this.txtLpgPrice.Size = new System.Drawing.Size(177, 32);
			this.txtLpgPrice.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(35, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 24);
			this.label7.TabIndex = 7;
			this.label7.Text = "Lpg:";
			// 
			// rdbGasoline
			// 
			this.rdbGasoline.AutoSize = true;
			this.rdbGasoline.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.rdbGasoline.Location = new System.Drawing.Point(6, 42);
			this.rdbGasoline.Name = "rdbGasoline";
			this.rdbGasoline.Size = new System.Drawing.Size(93, 28);
			this.rdbGasoline.TabIndex = 9;
			this.rdbGasoline.TabStop = true;
			this.rdbGasoline.Text = "Benzin";
			this.rdbGasoline.UseVisualStyleBackColor = true;
			// 
			// rdbDiesel
			// 
			this.rdbDiesel.AutoSize = true;
			this.rdbDiesel.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.rdbDiesel.Location = new System.Drawing.Point(128, 42);
			this.rdbDiesel.Name = "rdbDiesel";
			this.rdbDiesel.Size = new System.Drawing.Size(105, 28);
			this.rdbDiesel.TabIndex = 10;
			this.rdbDiesel.TabStop = true;
			this.rdbDiesel.Text = "Motorin";
			this.rdbDiesel.UseVisualStyleBackColor = true;
			// 
			// rdbLpg
			// 
			this.rdbLpg.AutoSize = true;
			this.rdbLpg.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.rdbLpg.Location = new System.Drawing.Point(269, 42);
			this.rdbLpg.Name = "rdbLpg";
			this.rdbLpg.Size = new System.Drawing.Size(66, 28);
			this.rdbLpg.TabIndex = 11;
			this.rdbLpg.TabStop = true;
			this.rdbLpg.Text = "Lpg";
			this.rdbLpg.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbGasoline);
			this.groupBox2.Controls.Add(this.rdbLpg);
			this.groupBox2.Controls.Add(this.rdbDiesel);
			this.groupBox2.Location = new System.Drawing.Point(146, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(344, 91);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yakıt Türü";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1076, 467);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtGasAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGasAmount;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLpgPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDieselPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGasolinePrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbGasoline;
		private System.Windows.Forms.RadioButton rdbDiesel;
		private System.Windows.Forms.RadioButton rdbLpg;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

